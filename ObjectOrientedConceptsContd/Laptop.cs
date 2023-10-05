using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConceptsContd
{
    internal class Laptop
    {
        //2 jobs----should be able to use a method in a special way
        //1 method----accept & display & do validations
        //property/attribute
        
        //variable---backing variable
        private int? _ram;

        //property/smart method
        public int? RAM { set { _ram = value; } get { return _ram; } }

        DateTime _mfgDate;
        public DateTime MfgDate 
        {
            set 
            { 
                _mfgDate=value;

            }
            get 
            {
                return _mfgDate;
            }
        
        }
        //propfull
        private bool? _fingersensor;

        public bool? FingerSensor
        {
            get { return _fingersensor; }
            set { _fingersensor = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }





        //propfull tab tab
        private Nullable<decimal> _price;//(down arrow key)
                   //(tab)
        public Nullable<decimal> Price
        {
            get 
            {
                if (_price == 0)
                {
                    Console.WriteLine("Price is 0");
                    return 0;
                }
                else
                    return _price;
            }
            set { 
                if(value>0)
                _price = value;
                else
                    Console.WriteLine("Not a valid value");
            }
        }
          int _hd;
        public int HardDisk 
        {
            set 
            {
                if (value>0)
                {
                    _hd = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }

            } 
            get { return _hd; } 
        }

        string _processor;
        public string Processor
        {
            set 
            {
                if (value != null)
                {
                    _processor = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }
            } 
            get { return _processor; } 
        }



    }
}
