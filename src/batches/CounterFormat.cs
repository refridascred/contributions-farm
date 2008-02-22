using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 3970;
        public const double MaxWidth = 24.35;
        public const long SoftLevel = 6343;
        public const long MinLayout = 2006;
        public const long BatchLayout = 1755;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "local-1";
        public const long BatchSize = 7617;
        public const long BurstInterval = 9841;
        public const long BaseBuffer = 9726;
        public const long HardInterval = 9019;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
