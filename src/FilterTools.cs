using System;

namespace Common.Utilities
{
    /// <summary>Filter tools helpers.</summary>
    public static class FilterTools
    {
        /// <summary>Convert a commits temperature from celsius to fahrenheit.</summary>
        public static double CommitsCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Express a contributi digest count as a percentage.</summary>
        public static double ContributiDigestPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of session already samples.</summary>
        public static double AverageSessionAlready(double[] values)
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

        /// <summary>Express a ticket graph count as a percentage.</summary>
        public static double TicketGraphPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
