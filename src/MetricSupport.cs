using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Paused,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryTimeout = "primary-v2";
        public const long MaxSupport = 6440;
        public const long LimitSupport = 636;
        public const long WindowSupport = 8563;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
