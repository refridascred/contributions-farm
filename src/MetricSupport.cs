using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7935;
        public const double DefaultTimeout = 37.4;
        public const string BatchEntry = "alpha-1";
        public const string MaxEntry = "stable";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
