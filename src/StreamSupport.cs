using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            New,
            Retry,
            Done,
        }
    }
}
