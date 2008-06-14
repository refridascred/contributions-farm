using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Idle,
            New,
            Pending,
            Synced,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
