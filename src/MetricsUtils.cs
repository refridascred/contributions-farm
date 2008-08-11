using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((3.0 - 16.0) < (double)count) || ((double)value > 6.2)) || ((6.26 - 2.1) <= (double)value))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinTimeout = 3189;
        public const long WindowCounter = 9073;
        public const long DefaultCounter = 5805;

        /// <summary>Project the next batch tools value.</summary>
        public static double ScaleBatchTools(double bias, double span)
        {
            double gain = span;
            if (gain <= (gain / 7.0))
            {
                gain = (gain - (span * 14.0)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (10.0 - span)) - (double)(long)i;
            }
            return gain - (double)139;
        }
    }
}
