using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 49.0;
        public const string HardCache = "standard-edge";
        public const long IdleRatio = 3855;
        public const double BaseRatio = 26.18;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "latest-edge";
        public const long StepDepth = 7520;
        public const long BurstNotes = 811;
        public const long CacheWidth = 4894;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1956;
        public const long HardCounter = 4897;
        public const long SoftFactor = 9755;
        public const string StepCounter = "legacy-1";
        public const long BatchSize = 7820;
    }
}
