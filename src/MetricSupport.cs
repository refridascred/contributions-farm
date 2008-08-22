using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1609;
        public const string SoftInterval = "staging-edge";
        public const long CacheWidth = 5615;
        public const long CacheCommand = 6916;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }
    }
}
