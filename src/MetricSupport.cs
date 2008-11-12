using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Draft,
            Stale,
            New,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstScore = 30.62;
        public const long BatchChannel = 1492;
        public const double WindowChannel = 27.75;
    }
}
