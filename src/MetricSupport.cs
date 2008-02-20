using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2645;
        public const long StepLevel = 3522;
        public const long MaxCount = 5109;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
