using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 3618;
        public const string DefaultContext = "legacy-1";
        public const long WindowTimeout = 4015;
        public const long MinContext = 7317;
        public const long IdleContext = 302;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
