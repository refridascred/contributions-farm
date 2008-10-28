using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((double)origin > (double)(-23))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (4.0 * 8.84))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double bias2 = (9.0 * 8.68) - 2.0;
            if (bias2 > ratio)
            {
                bias2 = (bias2 + (bias2 + 8.0)) + bias;
            }
            else
            {
                bias2 = bias2 - (double)(-61);
            }
            return bias2 + (double)8;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)((-730) << 3);
            if (mean <= (double)80)
            {
                mean = mean - offset;
            }
            return mean - (16.0 - scale);
        }

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool GuardTokenClusterRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
