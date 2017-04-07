using System;

namespace Common.Utilities
{
    /// <summary>Layout core helpers.</summary>
    public static class LayoutCore
    {
        /// <summary>Express a queue count as a percentage.</summary>
        public static double QueuePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
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
