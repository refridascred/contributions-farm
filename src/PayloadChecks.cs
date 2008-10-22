using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 6198;
        public const long LimitScore = 6457;
        public const string DefaultAlready = "staging";
        public const string StepWidth = "primary-1";
        public const long IdleLevel = 4625;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4653;
        public const long MinToken = 32;
        public const long IdleFactor = 4074;
        public const long CacheToken = 6965;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
