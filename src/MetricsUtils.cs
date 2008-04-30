using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6799;
        public const long HardAccount = 8697;
        public const double RetryAccount = 93.84;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Synced,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8220;
        public const double HardMetrics = 67.0;
        public const long DefaultWidth = 4875;
    }
}
