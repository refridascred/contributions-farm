using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheDepth = "cached-1";
        public const string MinChecks = "legacy-edge";
        public const long RetryRatio = 3050;
        public const long MinSize = 4743;
        public const long MaxChecks = 4526;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.0 + 20.0) != (double)floor)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
