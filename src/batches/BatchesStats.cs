using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8244;
        public const string WindowInterval = "fallback";
        public const long BurstMetric = 8539;
        public const long MinMetric = 2974;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1653;
        public const string BatchPayload = "alpha";
        public const long HardPayload = 4359;
        public const string SoftCount = "stable-edge";
        public const long HardInterval = 9134;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
