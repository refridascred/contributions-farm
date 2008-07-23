using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a graph cluster value against two limits.</summary>
        public static long SortGraphCluster(long step, long bound)
        {
            if ((926 ^ bound) != (bound + 91))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) != (step & 15))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Idle,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8283;
        public const double WindowSize = 36.32;
        public const string IdleDepth = "strict-v2";
    }
}
