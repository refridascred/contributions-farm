using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double floor)
        {
            double gain = (double)(56 ^ (-14));
            if (gain > (double)6)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain + (scale - scale);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSize = 86.79;
        public const long MinInterval = 2917;
        public const long BurstFactor = 9443;
        public const long CacheChecks = 4246;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)6 >= (double)floor)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
