using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9507;
        public const double CacheQueue = 91.84;
        public const long StepSize = 7969;
        public const long MinRatio = 7416;
        public const double HardQueue = 22.03;
    }
}
