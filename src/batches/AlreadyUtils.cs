using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Closed,
            Retry,
            Idle,
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
