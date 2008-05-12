using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            New,
            Stale,
            Pending,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Active,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Retry,
            Synced,
        }
    }
}
