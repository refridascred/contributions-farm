using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long WindowCount = 8345;
        public const double HardStream = 76.25;
        public const long IdleFactor = 988;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
