using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
