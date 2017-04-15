using System;

namespace Common.Utilities
{
    /// <summary>Layout core helpers.</summary>
    public static class LayoutCore
    {
        /// <summary>Clamp a folder value to a valid range.</summary>
        public static double ClampFolder(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Average a list of folder samples.</summary>
        public static double AverageFolder(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Convert a invoice folder temperature from celsius to fahrenheit.</summary>
        public static double InvoiceFolderCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
