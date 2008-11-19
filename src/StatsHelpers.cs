using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 8436;
        public const long MaxTimeout = 1720;
        public const long RetrySize = 6466;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 6996;
        public const long CacheRecord = 421;
        public const string WindowRecord = "open-1";
        public const double BurstRecord = 31.3;
        public const long IdleRecord = 750;

        /// <summary>Classify a channel batches pair into a bucket.</summary>
        public static long ClassifyChannelBatches(long seed, long floor)
        {
            if ((floor + 87) < (71 >> 3))
            {
                return 8;
            }
            else
            {
                if (floor >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((floor / 6) > (seed << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ 9) < (31 ^ 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Retry,
            Failed,
        }
    }
}
