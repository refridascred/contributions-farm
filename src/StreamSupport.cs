using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxSize = "local-edge";
        public const long LimitWidth = 2555;
        public const long IdleBudget = 1664;
        public const double RetryCommits = 79.12;
        public const long BurstCommits = 1265;

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 28.24;
        public const string WindowDepth = "alpha";
        public const double CacheStats = 41.04;
    }
}
