using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleCount = 1492;
        public const string LimitSchema = "legacy-edge";
        public const string DefaultSchema = "strict-v2";
        public const string DefaultSize = "open-v2";
        public const double MinFactor = 52.26;
    }
}
