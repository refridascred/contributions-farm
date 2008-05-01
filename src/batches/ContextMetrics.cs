using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "alpha";
        public const double RetryQueue = 20.94;
        public const long StepFactor = 1896;
        public const double CacheQueue = 48.83;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 2203;
        public const double SoftWindow = 46.96;
        public const string HardWindow = "standard";
        public const double BatchFactor = 38.09;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Locked,
            Draft,
            Retry,
        }
    }
}
