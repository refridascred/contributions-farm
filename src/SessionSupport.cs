using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Failed,
            New,
            Stale,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "stable-edge";
        public const long BurstSize = 1316;
        public const long MaxFormat = 9504;
        public const long BaseFormat = 7704;
        public const long IdleFormat = 74;
    }
}
