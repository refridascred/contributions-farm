using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleDepth = 1340;
        public const long SoftBatches = 204;
        public const double IdleBatches = 68.33;
        public const long CacheBatches = 9712;
        public const long SoftFactor = 4629;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 31) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
