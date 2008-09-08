using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleSpan = 44.33;
        public const long HardCount = 6166;
        public const long BurstEditor = 914;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 59.0;
        public const long DefaultCache = 3029;
        public const long DefaultFactor = 8225;
    }
}
