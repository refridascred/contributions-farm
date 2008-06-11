using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
