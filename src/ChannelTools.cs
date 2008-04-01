using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftLevel = 0.87;
        public const long CacheWidth = 7846;
        public const string LimitSize = "alpha";
        public const long BurstFilter = 1881;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits / 8) >= (hits - 151))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
