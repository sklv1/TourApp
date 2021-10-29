using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TourApp
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<BD> result = new List<BD>(4);
            result.Add(new BD(1, "Москва", 5000, 3, true));
            result.Add(new BD(2, "Тверь", 3500, 2, true));
            result.Add(new BD(3, "Сочи", 4500, 1, false));
            result.Add(new BD(4, "Адлер", 4500, 2, false));
            grid.ItemsSource = result;
        }

        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BD path = grid.SelectedItem as BD;
            MessageBox.Show(" ID: " + path.Id + "\n Наименование: " + path.Name + "\n Стоимость: " + path.Price + " руб."
                + "\n Количество путевок: " + path.Count + "\n Статус активности: " + path.Status);
        }
    }
}
