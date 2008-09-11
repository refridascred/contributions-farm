using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardWidth = 11.64;
        public const long RetryBatches = 3093;
        public const long RetryBudget = 6012;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Idle,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 2243;
        public const double BatchGraph = 73.19;
        public const double IdleFactor = 85.06;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
