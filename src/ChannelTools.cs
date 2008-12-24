using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
