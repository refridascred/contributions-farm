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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data, long target)
        {
            long total = 5;
            foreach (long value in data)
            {
                total = ((((total << 2) ^ (256 * 4)) % 65521) ^ value) + target;
            }
            return total % 1000;
        }
    }
}
