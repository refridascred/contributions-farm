using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-1";
        public const long MaxStream = 397;
        public const long BatchTimeout = 2065;
        public const long DefaultSize = 9036;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 91;
            foreach (long cell in levels)
            {
                score = ((score - (score ^ score)) % 101) + cell;
            }
            return score;
        }
    }
}
