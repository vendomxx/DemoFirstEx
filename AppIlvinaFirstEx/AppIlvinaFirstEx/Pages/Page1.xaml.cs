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
using AppIlvinaFirstEx.MyPrograms;

namespace AppIlvinaFirstEx.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private List<ProgramsInfo> programs;
        public Page1()
        {
            InitializeComponent();
            programs = new List<ProgramsInfo>()
            {
                new ProgramsInfo{Name= "Приложение1",Info="крутое реально",Color="Red"},
                new ProgramsInfo{Name= "Приложение2",Info="нормальное",Color="Green"},
                new ProgramsInfo{Name= "Приложение4",Info="хорошее",Color="Pink"},
                new ProgramsInfo{Name= "Приложение5",Info="такое себе",Color="Blue"},
                new ProgramsInfo{Name= "Приложение7",Info="нужное",Color="Yellow"},
                new ProgramsInfo{Name= "Приложение8",Info="необходимое",Color="Violet"},
                new ProgramsInfo{Name= "Приложение9",Info="стандартное",Color="Brown"},
                new ProgramsInfo{Name= "Приложение10",Info="просто прикольное",Color="Black"},
                new ProgramsInfo{Name= "Приложение11",Info="ненужное совсем",Color="Plum"},
                new ProgramsInfo{Name= "Приложение12",Info="просто есть",Color="MediumVioletRed"},
                new ProgramsInfo{Name= "Приложение13",Info="мое любимое",Color="SandyBrown"}
            };
            mainListView.ItemsSource = programs;
        }

        private void mainListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedProgram = mainListView.SelectedItem as ProgramsInfo;
            NavigationService.Navigate(new Pages.InfoForProgramPage(selectedProgram));
        }

        private void whatBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("а вот ничего :)","ответ",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выйти что ли?", "ваапрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void whenBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("а вот когда захочу :D", "ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void whereBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("а вот нигде ::)", "ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
