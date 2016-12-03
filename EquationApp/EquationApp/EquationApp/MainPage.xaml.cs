﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Views.Equations;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void NavigatePageVelocity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VelocityEquationPage());
        }
    }
}
