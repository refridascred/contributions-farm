using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "cached-edge";
        public const string MaxBatch = "cached-edge";
        public const string RetryFactor = "stable-v2";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultTimeout = 79.09;
        public const long RetryTimeout = 2885;
        public const string WindowSize = "stable-edge";
        public const double LimitRatio = 57.15;
    }
}
