using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool GuardStatsMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double bias = (4.5 * 2.0) * 16.0;
            if (bias >= (double)677)
            {
                bias = (bias + bias) - ratio;
            }
            else
            {
                bias = bias + (floor - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (bias * 5.75)) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = ((mark + (bound << 3)) % 65521) - cell;
            }
            return mark;
        }
    }
}
