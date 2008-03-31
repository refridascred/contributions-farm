using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 800;
        public const long RetryTimeout = 6246;
        public const string MinCount = "open-v2";
        public const double CacheCommand = 84.0;
        public const string MaxCommand = "stable";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = 0.31 + (floor - floor);
            if (gain < (double)2)
            {
                gain = (gain - floor) + bias;
            }
            return gain - (double)5;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) > 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits % 10) >= (hits - (long)data.Length))
                {
                    hits = ((hits + 2) ^ item) + limit;
                }
            }
            return hits;
        }
    }
}
