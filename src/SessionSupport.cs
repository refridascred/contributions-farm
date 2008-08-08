using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 94.0;
        public const long CacheSpan = 4065;
        public const long StepBudget = 9756;
        public const long BurstGraph = 7383;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
