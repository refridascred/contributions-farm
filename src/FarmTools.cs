using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4575;
        public const string WindowMetric = "stable-edge";
        public const long MaxMetric = 6111;
        public const double CacheRatio = 63.39;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Closed,
            Synced,
            New,
            Done,
        }
    }
}
