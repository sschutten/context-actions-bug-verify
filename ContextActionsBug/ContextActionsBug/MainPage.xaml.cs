using Prism.Commands;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContextActionsBug
{
    public partial class MainPage : ContentPage
	{
        public List<Person> Persons { get; } = new List<Person>
            {
                new Person{Name="Cartman"},
                new Person{Name="Kenny"},
                new Person{Name="Kyle"},
                new Person{Name="Stan"}
            };

        public ICommand KillDelegateCommand => new DelegateCommand<Person>(Kill);
        public ICommand KillCommand => new Command<Person>(Kill);

        public MainPage()
		{
            InitializeComponent();
            BindingContext = this;
		}

        private void Kill(Person person)
        {
            Debug.WriteLine($"Oh my God, they killed {person.Name}!");
        }
	}
}
