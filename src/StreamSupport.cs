using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Pending,
            Retry,
            Queued,
            Synced,
        }
    }
}
