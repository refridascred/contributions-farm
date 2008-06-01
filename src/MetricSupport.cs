using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitCount = 8792;
        public const long RetryBudget = 9592;
        public const double BurstSize = 91.1;
        public const long SoftInterval = 4659;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 6991;
        public const long StepCount = 6789;
        public const long MaxContributi = 1246;
        public const string IdleCount = "standard-1";
        public const string HardLevel = "cached-edge";
    }
}
