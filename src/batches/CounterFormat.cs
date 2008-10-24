using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 4681;
        public const long BaseRatio = 7662;
        public const long HardDepth = 6171;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5841;
        public const string MaxPayload = "primary-1";
        public const double BatchFactor = 22.92;
        public const string WindowDepth = "legacy";
        public const string RetryPayload = "fallback-v2";
    }
}
