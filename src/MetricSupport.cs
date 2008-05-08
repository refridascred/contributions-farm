using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "standard-v2";
        public const string IdleTimeout = "staging-1";
        public const long HardScore = 8555;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
