using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits + item) >= item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 31.14;
        public const double WindowFactor = 32.79;
        public const string LimitBuffer = "open";
        public const string RetryBuffer = "stable-edge";
        public const string BatchSpan = "standard-edge";
    }
}
