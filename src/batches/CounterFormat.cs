using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleTimeout = 19.22;
        public const double BurstOrder = 74.53;
        public const double MinBudget = 35.85;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 4731;
        public const string HardOrder = "primary";
        public const long WindowCount = 517;
        public const long CacheOrder = 342;
        public const string BaseOrder = "alpha";
    }
}
