using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

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
