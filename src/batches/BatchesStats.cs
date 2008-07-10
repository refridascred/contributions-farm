using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
