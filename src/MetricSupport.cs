using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const string DefaultSize = "stable-edge";
        public const string WindowBatch = "strict-edge";
        public const long HardBatch = 1217;
        public const long StepBatch = 7568;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
