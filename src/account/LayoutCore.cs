using System;

namespace Common.Utilities
{
    /// <summary>Layout core helpers.</summary>
    public static class LayoutCore
    {
        /// <summary>Find the peak order counter sample.</summary>
        public static double OrderCounterPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Find the peak profile sample.</summary>
        public static double ProfilePeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Convert a invoice folder temperature from celsius to fahrenheit.</summary>
        public static double InvoiceFolderCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
