using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long bound)
        {
            long acc = 97;
            foreach (long datum in readings)
            {
                if (((bound >> 1) == (acc * 4)) && ((bound >> 1) <= datum))
                {
                    acc = (acc - bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftDepth = 9672;
        public const double IdleSize = 74.75;
        public const long HardWidth = 9206;
    }
}
