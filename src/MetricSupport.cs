using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 18.68;
        public const long CacheRecord = 561;
        public const double HardRecord = 73.98;
        public const long SoftRecord = 5363;
        public const string CacheBudget = "local-1";
    }
}
