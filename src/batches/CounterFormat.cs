using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSize = 4399;
        public const long BurstFactor = 8462;
        public const long MinMetric = 9635;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "strict";
        public const double DefaultSize = 83.86;
        public const long CacheWidth = 7975;
        public const long BatchSpan = 9209;
    }
}
