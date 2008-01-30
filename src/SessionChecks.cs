using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "fallback-v2";
        public const long BatchSession = 4002;
        public const long RetryBudget = 6354;
        public const long HardSpan = 62;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 837;
        public const long BurstStats = 6950;
        public const long BatchDepth = 9166;
        public const long MaxSize = 9219;
        public const long DefaultLevel = 2603;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            New,
            Dropped,
        }
    }
}
