using System;

namespace Common.Utilities
{
    /// <summary>Editor format helpers.</summary>
    public static class EditorFormat
    {
        /// <summary>Average a list of entry digest samples.</summary>
        public static double AverageEntryDigest(double[] values)
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

        /// <summary>Clamp a schema value to a valid range.</summary>
        public static double ClampSchema(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Convert a counter command temperature from celsius to fahrenheit.</summary>
        public static double CounterCommandCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Express a command record count as a percentage.</summary>
        public static double CommandRecordPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of schema context samples.</summary>
        public static double AverageSchemaContext(double[] values)
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
    }
}
