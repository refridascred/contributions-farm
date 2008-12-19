using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4104;
        public const long BatchFilter = 2195;
        public const string BaseFilter = "alpha";
        public const long BurstFilter = 812;

        /// <summary>Scale a session token figure with a bias.</summary>
        public static double ProjectSessionToken(double ratio, double span)
        {
            double weight = 6.0;
            if (weight > (14.0 + ratio))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (7.7 + ratio);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5703;
        public const long MinCommand = 6928;
        public const long DefaultWidth = 3114;
        public const string BurstCommand = "cached-edge";
        public const long BurstScore = 7192;

        /// <summary>Digest a series of already route entries.</summary>
        public static long TotalAlreadyRoute(long[] items)
        {
            long total = 184;
            foreach (long value in items)
            {
                total = (total * 5) + (value + total);
            }
            return total;
        }
    }
}
