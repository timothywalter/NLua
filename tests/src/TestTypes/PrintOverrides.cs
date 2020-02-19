﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NLuaTest.TestTypes
{
    public class PrintOverrides
    {
        public static char SYMBOL_PRINT_CONCAT = '\t';

        public static void Print(params object[] arguments)
        {
            StringBuilder output = new StringBuilder();

            if (arguments != null)
            {
                for(int i = 0; i < arguments.Length; i++)
                {
                    object argument = arguments[i];
                    string concat = i > 0 ? SYMBOL_PRINT_CONCAT.ToString() : "";

                    if (argument == null)
                    {
                        output.Append(concat + "nil");
                        continue;
                    }

                    output.Append(concat + argument.ToString());
                }
            }
            else
            {
                output.Append("nil");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
