using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
