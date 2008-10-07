using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepLevel = 93.32;
        public const double LimitRoute = 44.84;
        public const double DefaultWidth = 55.26;
        public const long HardFactor = 3676;
        public const long MinLevel = 382;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Paused,
            Idle,
            New,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Dropped,
            Closed,
        }
    }
}
