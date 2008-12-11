using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 6946;
        public const long LimitFactor = 7937;
        public const double RetryBudget = 49.17;
        public const long CacheRatio = 9637;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Ready,
            Active,
        }
    }
}
