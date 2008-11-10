using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 574;
        public const long DefaultStream = 5563;
        public const long RetryDepth = 2248;
        public const double BurstStream = 40.22;
        public const string HardScore = "cached-v2";
    }
}
