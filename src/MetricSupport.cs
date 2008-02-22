using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultDepth = "primary-1";
        public const double HardBuffer = 69.91;
        public const long BaseLevel = 9079;
        public const long BatchBuffer = 5496;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
        }
    }
}
