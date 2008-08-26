using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstInterval = 5766;
        public const string HardDepth = "alpha";
        public const string RetryLevel = "strict-edge";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((sample + hits) <= (hits - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
