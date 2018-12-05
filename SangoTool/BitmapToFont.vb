﻿Public Class ToFont
    Dim Config As String = Application.StartupPath + "\SangoTool.ini"
    Dim FontFile As String = GetINI("FontTool", "BitmapToFontFile", "", Config)
    Dim ImagePath As String = GetINI("FontTool", "BitmapToFontPath", "", Config)
    Dim CodePage = 950

    Private Sub ButtonBitmapToFont_Click(sender As Object, e As EventArgs) Handles ButtonBitmapToFont.Click
        BitmapToFont(ImagePath, FontFile, CodePage, ProgressBarBitmapToFont)
    End Sub

    Private Sub ButtonBitmapToFontPath_Click(sender As Object, e As EventArgs) Handles ButtonBitmapToFontPath.Click
        FolderBrowserDialog1.ShowDialog()
        ImagePath = FolderBrowserDialog1.SelectedPath
        TextBoxBitmapToFontPath.Text = ImagePath
        WriteINI("FontTool", "BitmapToFontPath", ImagePath, Config)
    End Sub

    Private Sub ButtonBitmapToFontFile_Click(sender As Object, e As EventArgs) Handles ButtonBitmapToFontFile.Click
        SaveFileDialog1.ShowDialog()
        FontFile = SaveFileDialog1.FileName
        TextBoxBitmapToFontFile.Text = FontFile
        WriteINI("FontTool", "BitmapToFontFile", FontFile, Config)
    End Sub

    Private Sub CheckBoxBitmapToFontBig5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBitmapToFontBig5.CheckedChanged
        CheckBoxBitmapToFontGBK.Checked = Not CheckBoxBitmapToFontBig5.Checked
        If CheckBoxBitmapToFontGBK.Checked = True Then CodePage = 936
        If CheckBoxBitmapToFontBig5.Checked = True Then CodePage = 950
    End Sub

    Private Sub CheckBoxBitmapToFontGBK_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBitmapToFontGBK.CheckedChanged
        CheckBoxBitmapToFontBig5.Checked = Not CheckBoxBitmapToFontGBK.Checked
    End Sub

    Private Sub ToFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxBitmapToFontFile.Text = FontFile
        TextBoxBitmapToFontPath.Text = ImagePath
    End Sub
End Class