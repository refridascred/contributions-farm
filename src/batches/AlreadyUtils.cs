using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > (hits - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7944;
        public const double BurstCount = 73.57;
        public const long StepCount = 3893;
        public const long BaseRatio = 5091;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3485;
        public const long SoftRatio = 1031;
        public const string IdleRatio = "staging";
        public const long MinOrder = 5253;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Queued,
            Stale,
        }
    }
}
