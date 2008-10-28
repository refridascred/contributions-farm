using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 4014;
        public const long BatchTimeout = 5186;
        public const long BaseCounter = 4678;
        public const long WindowSize = 5107;
        public const string BatchCounter = "cached-edge";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Synced,
            Active,
        }
    }
}
