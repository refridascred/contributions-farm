using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 7703;
        public const long DefaultPayload = 7751;
        public const long CacheInterval = 4133;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Queued,
            Pending,
            Active,
        }
    }
}
