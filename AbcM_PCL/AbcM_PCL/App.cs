using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AbcM_PCL
{
    public class App : Application
    {
        // configuration of app
        int number_of_levels = 5;
        public int currentLevel_number { get; private set; }

        int number_of_items_in_firstLevel = 3;
        int number_of_items_IncrementEachLevel = 1;

        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void showStuffs(int level_number)
        {
            // levels defination
            // initialization of levels on generic level #TBD
            int[] levels = new int[number_of_levels];

            // fetching items to be shown
            List<string> level_items = new List<string>();
            if (level_number == 1)
            {
                List<string> Item2bShown = getItems2bShown(number_of_items_in_firstLevel);
            }
            else
            {
                currentLevel_number= currentLevel_number + number_of_items_IncrementEachLevel;
                level_items = getItems2bShown(level_number);
            }
            //showing items
            for (int i = 0; i < number_of_levels; i++)
            {
                
            }
        }

        private List<string> getItems2bShown(int level_number)
        {
            List<string> Item2bShown = new List<string>();

            for (int i = 0; i < level_number; i++)
            {
                //implement random TBD
                //implement i18n TBD
                
                // Characters a &alpha; क #testCode
                char a = 'a';
                Item2bShown.Add(String.Format("{0} character has code: {1}", a, ((int)'a').ToString()));
            }
            
            return Item2bShown;
        }
    }
}
