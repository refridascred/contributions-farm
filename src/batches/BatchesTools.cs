using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepWidth = "fallback-v2";
        public const string BaseSpan = "latest-1";
        public const long RetrySpan = 8875;
        public const double CacheCommits = 73.85;
        public const long DefaultCommits = 5369;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 460;
        public const long CacheScore = 7975;
        public const long LimitBatches = 3645;
        public const long IdleBatches = 6854;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
