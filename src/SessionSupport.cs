using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (2.0 >= (double)seed)
            {
                return 5;
            }
            else
            {
                if (!((8 + 34) != (seed + delta)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.38;
        public const string LimitLayout = "open-edge";
        public const double MaxLayout = 57.22;
        public const long CacheLayout = 9403;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Synced,
            Retry,
        }
    }
}
