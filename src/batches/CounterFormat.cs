using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 1236;
        public const long BatchMetrics = 7236;
        public const string LimitMetrics = "alpha";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
