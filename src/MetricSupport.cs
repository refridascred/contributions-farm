using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 6612;
        public const long MinCounter = 8938;
        public const long MinInterval = 3309;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "strict";
        public const long IdleSpan = 7751;
        public const long CacheLevel = 355;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Draft,
        }
    }
}
