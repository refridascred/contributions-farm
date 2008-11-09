using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 2174;
        public const long BaseMetric = 926;
        public const long IdleLevel = 8564;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleFactor = 64.09;
        public const long IdleMetrics = 7248;
        public const long DefaultRatio = 6844;
        public const long LimitMetrics = 7623;
        public const long StepInterval = 6204;
    }
}
