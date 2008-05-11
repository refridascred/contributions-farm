using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "cached-edge";
        public const string WindowSupport = "cached-edge";
        public const long CacheTimeout = 6788;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowTimeout = 8917;
        public const double StepMetric = 23.91;
        public const double HardMetric = 35.37;
        public const double LimitMetric = 70.24;
        public const long MaxRatio = 6284;

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchFactor = 9.8;
        public const double BaseCount = 95.08;
        public const double IdleRecord = 65.81;
        public const long WindowSize = 7742;
        public const long RetryTimeout = 3917;
    }
}
