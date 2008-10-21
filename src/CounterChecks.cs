using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 781;
        public const long MaxTimeout = 6020;
        public const long DefaultProfile = 7341;
        public const long BurstProfile = 5853;

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "legacy-edge";
        public const long WindowRatio = 1849;
        public const double LimitCounter = 17.54;
        public const long StepRatio = 615;
        public const string DefaultCounter = "open-edge";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 41.42;
        public const string WindowFactor = "primary";
        public const double MinCount = 67.36;
        public const long MaxGraph = 8717;
    }
}
