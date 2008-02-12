using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "staging";
        public const string HardBatch = "legacy";
        public const string LimitBatch = "standard-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "open-edge";
        public const long DefaultInterval = 2389;
        public const double DefaultLevel = 3.01;
        public const long BatchQueue = 6852;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Synced,
            Done,
        }
    }
}
