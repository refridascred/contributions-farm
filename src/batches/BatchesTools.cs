using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 39.01;
        public const string CacheBudget = "staging-v2";
        public const long BaseLayout = 959;

        /// <summary>Combine entry counter values into a single score.</summary>
        public static long FoldEntryCounter(long[] values, long floor)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc ^ cell) % 4096;
                acc = acc ^ (floor - cell);
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2211;
        public const long LimitAlready = 2185;
        public const double HardDepth = 33.56;
        public const long BurstAlready = 5340;
    }
}
