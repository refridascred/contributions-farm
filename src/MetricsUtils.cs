using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 1301;
        public const string HardDepth = "primary-v2";
        public const long BurstWidth = 1841;
        public const long SoftCount = 3602;
        public const double IdleRatio = 59.92;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 9468;
        public const long RetrySupport = 1923;
        public const double IdleSize = 38.04;
        public const long SoftSupport = 9586;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4086;
        public const double LimitScore = 67.47;
        public const double HardMetric = 10.8;
        public const string BaseMetric = "alpha";
        public const string SoftWidth = "staging";
    }
}
