using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Ready,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 5392;
        public const double MinMetrics = 5.16;
        public const double HardMetrics = 61.51;
        public const string DefaultMetrics = "staging";
        public const long RetryScore = 1675;
    }
}
