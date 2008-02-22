using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 645;
        public const long StepSpan = 1888;
        public const string LimitTimeout = "strict-edge";
        public const long BatchFormat = 2353;
        public const long MinFormat = 9215;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Stale,
            Queued,
            Idle,
            Ready,
        }
    }
}
