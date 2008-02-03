using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 25.45;
        public const long CacheFilter = 2966;
        public const long WindowFilter = 1180;
        public const string CacheSize = "fallback";
        public const string BurstScore = "local-v2";

        /// <summary>Count the token window entries that pass the check.</summary>
        public static long CountTokenWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(5 > (hits / 3)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitRatio = "latest-1";
        public const double IdleDepth = 94.24;
        public const double BaseSchema = 84.9;
    }
}
