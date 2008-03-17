using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)85 < (double)hits)
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 2025;
        public const string CacheSpan = "fallback-v2";
        public const long DefaultTools = 3228;
        public const long DefaultWidth = 5537;
        public const double SoftTools = 51.93;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 6380;
        public const double BurstStream = 6.67;
        public const long HardStream = 3569;
        public const long BurstWidth = 5448;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
