using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "primary-v2";
        public const string WindowQueue = "strict-edge";
        public const double DefaultQueue = 43.28;
        public const double BatchDepth = 74.14;
        public const string BurstQueue = "local-v2";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
