using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Draft,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Closed,
            Idle,
            New,
        }
    }
}
