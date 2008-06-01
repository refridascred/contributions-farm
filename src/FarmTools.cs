using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSpan = 8425;
        public const double LimitFormat = 90.82;
        public const double IdleCount = 18.3;
        public const long BaseFormat = 1162;
        public const string RetryWidth = "staging";

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
