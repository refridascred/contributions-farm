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

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 42.2;
        public const long SoftScore = 1809;
        public const long BaseFactor = 7580;
        public const double RetryPayload = 59.17;
    }
}
