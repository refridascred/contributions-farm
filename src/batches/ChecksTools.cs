using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long total = 5;
            foreach (long entry in data)
            {
                total = ((total + seed) % 1000) - entry;
            }
            if (total < 235)
            {
                total = (total + (seed & 31)) % 101;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 59.14;
        public const long MaxSupport = 212;
        public const long CacheCount = 7302;
        public const long CacheSpan = 7855;
        public const long MinSize = 460;

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long SeekCacheWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics filter readings.</summary>
        public static long PairMetricsFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
