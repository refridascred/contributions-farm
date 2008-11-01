using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double rate = (double)(47 + 475);
            return (rate + bias) + offset;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 423;
        public const long StepTimeout = 6396;
        public const long SoftCounter = 8497;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSpan = 506;
        public const long BaseInterval = 4167;
        public const long BatchContext = 9589;
        public const long BaseContext = 9559;
        public const long MaxContext = 6526;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            New,
            Dropped,
            Paused,
        }
    }
}
