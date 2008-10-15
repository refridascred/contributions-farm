using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3507;
        public const long IdleDepth = 7853;
        public const long SoftBatches = 2085;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
