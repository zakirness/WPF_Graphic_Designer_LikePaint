using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace graff
{
    public partial class MainWindow : Window
    {
        Color blackColor = Color.FromRgb(000, 000, 000);
        Color magentaColor = Color.FromRgb(148, 21, 139);
        Color redColor = Color.FromRgb(252, 3, 3);
        Color blueColor = Color.FromRgb(3, 7, 252);
        Color greenColor = Color.FromRgb(29, 173, 56);
        Color orangeColor = Color.FromRgb(252, 102, 0);
        Color yeallowColor = Color.FromRgb(255, 255, 0);
        Color whiteColor = Color.FromRgb(255, 255, 255); 

        public MainWindow()
        {
            InitializeComponent();
            draw.Color = blackColor;
        }

        private void SetColor(object sender, RoutedEventArgs e)
        {
            string nameButton = (sender as Button).Content.ToString();
            int wh = Convert.ToInt32(slider.Value);

            switch (nameButton)
            {
                case "Magenta":
                    WHdraw(wh, magentaColor);
                    break;
                case "Black":
                    WHdraw(wh, blackColor);
                    break;
                case "Red":
                    WHdraw(wh, redColor);
                    break;
                case "Blue":
                    WHdraw(wh, blueColor);
                    break;
                case "Green":
                    WHdraw(wh, greenColor);
                    break;
                case "Orange":
                    WHdraw(wh, orangeColor);
                    break;
                case "Yeallow":
                    WHdraw(wh, yeallowColor);
                    break;
                case "Стёрка":
                    WHdraw(wh ,whiteColor);
                    break;
            }
        }

        private void WHdraw(int wh, Color color)
        {
            int defaultCountWH = 10;
            int mathX10 = 10;

            draw.Color = color;

            if (wh == 0) 
            { 
                wh = defaultCountWH;
            } 
            else
            {
                draw.Height = wh * mathX10;
                draw.Width = wh * mathX10;
            }
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }
    }
}
