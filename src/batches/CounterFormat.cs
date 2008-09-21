using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 9267;
        public const string MinTimeout = "primary-v2";
        public const long IdleCommand = 395;
    }
}
