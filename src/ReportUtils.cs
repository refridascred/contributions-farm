using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "legacy";
        public const long RetrySession = 7425;
        public const double RetryBudget = 40.75;
        public const long IdleSession = 9291;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Synced,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSpan = "stable";
        public const long DefaultCount = 5182;
        public const long WindowInterval = 1929;
        public const long RetryInterval = 8247;
        public const long MinFactor = 4653;
    }
}
