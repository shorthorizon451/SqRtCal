Module sqrtcalsourceModule
    Dim X, Y As Primitive
    Sub Main()
        TextWindow.WriteLine("")
        Program.Delay(2000)
        TextWindow.Clear()
        TextWindow.ForegroundColor = 1
        TextWindow.WriteLine("$$\   $$\                     $$\                                $$$$$$\                                ")
        Program.Delay(120)
        TextWindow.WriteLine("$$ |  $$ |                    \__|                              $$  __$$\                               ")
        Program.Delay(120)
        TextWindow.WriteLine("$$ |  $$ | $$$$$$\   $$$$$$\  $$\ $$$$$$$$\  $$$$$$\  $$$$$$$\  $$ /  \__| $$$$$$\   $$$$$$\   $$$$$$\  ")
        Program.Delay(120)
        TextWindow.ForegroundColor = 14
        TextWindow.WriteLine("$$$$$$$$ |$$  __$$\ $$  __$$\ $$ |\____$$  |$$  __$$\ $$  __$$\ $$ |      $$  __$$\ $$  __$$\ $$  __$$\ ")
        Program.Delay(120)
        TextWindow.WriteLine("$$  __$$ |$$ /  $$ |$$ |  \__|$$ |  $$$$ _/ $$ /  $$ |$$ |  $$ |$$ |      $$ /  $$ |$$ |  \__|$$ /  $$ |")
        Program.Delay(120)
        TextWindow.WriteLine("$$ |  $$ |$$ |  $$ |$$ |      $$ | $$  _/   $$ |  $$ |$$ |  $$ |$$ |  $$\ $$ |  $$ |$$ |      $$ |  $$ |")
        Program.Delay(120)
        TextWindow.ForegroundColor = 10
        TextWindow.WriteLine("$$ |  $$ |\$$$$$$  |$$ |      $$ |$$$$$$$$\ \$$$$$$  |$$ |  $$ |\$$$$$$  |\$$$$$$  |$$ |      $$$$$$$  |")
        Program.Delay(120)
        TextWindow.WriteLine("\__|  \__| \______/ \__|      \__|\________| \______/ \__|  \__| \______/  \______/ \__|      $$  ____/ ")
        Program.Delay(120)
        TextWindow.WriteLine("                                                                                              $$ |      ")
        Program.Delay(120)
        TextWindow.WriteLine("                                                                                              $$ |      ")
        Program.Delay(120)
        TextWindow.WriteLine("                                                                                              \__|      ")
        TextWindow.WriteLine("")
        TextWindow.WriteLine("")
        TextWindow.ForegroundColor = 15
        TextWindow.WriteLine("Microsoft (R) Small Basic v.1.2")
        Program.Delay(60)
        TextWindow.WriteLine("Copyright (R) Horizon Corp, Created with Microsoft (R) Small Basic")
        Program.Delay(50)
        TextWindow.WriteLine("All Rights Reserved")
        TextWindow.ForegroundColor = 7
        TextWindow.Pause()
        TextWindow.Clear()
        TextWindow.ForegroundColor = 15
        TextWindow.WriteLine("Welcome to SqRtCal!")
        TextWindow.Write("Enter your desired number to compute:")
        X = TextWindow.ReadNumber()
        Y = Microsoft.SmallBasic.Library.Math.SquareRoot(X)
        TextWindow.Write("The answer is:")
        TextWindow.WriteLine(Y)
        TextWindow.Pause()
        TextWindow.Clear()
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Thank you for using this program.")
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Copyright @2022 HorizonCorp")
        TextWindow.ForegroundColor = 11
        TextWindow.WriteLine("     _____                 ____   ____             _     ")
        TextWindow.WriteLine("    / ___/____ ___  ____ _/ / /  / __ )____ ______(_)____")
        TextWindow.WriteLine("    \__ \/ __ `__ \/ __ `/ / /  / __  / __ `/ ___/ / ___/")
        TextWindow.WriteLine("   ___/ / / / / / / /_/ / / /  / /_/ / /_/ (__  ) / /__  ")
        TextWindow.WriteLine("  /____/_/ /_/ /_/\__,_/_/_/  /_____/\__,_/____/_/\___/  ")
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Copyright (R) 1985 - 2015 Microsoft Corporation")
        TextWindow.ForegroundColor = 8
        TextWindow.Pause()
        Program.End()
    End Sub
End Module
