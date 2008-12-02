using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if (33 > (target * 2))
                {
                    state = state + target;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3379;
        public const string LimitCounter = "legacy-edge";
        public const long SoftCount = 2440;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (seed + seed)) % 97;
                if (seed >= (sum + seed))
                {
                    sum = (sum - (sum + sum)) % 255;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
