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

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowWidth = 48.86;
        public const long StepLevel = 2165;
        public const long RetryFactor = 1192;
        public const double StepReport = 18.5;
    }
}
