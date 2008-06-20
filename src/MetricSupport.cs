using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 1921;
        public const long HardCounter = 7857;
        public const long RetryWidth = 6863;
        public const double BatchDepth = 15.45;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 8880;
        public const long MaxScore = 1518;
        public const long SoftOrder = 9641;
    }
}
