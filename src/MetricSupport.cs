using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
