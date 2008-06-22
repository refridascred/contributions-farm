using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 2541;
        public const long SoftFactor = 3138;
        public const long RetryWidth = 2998;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Draft,
            Queued,
        }
    }
}
