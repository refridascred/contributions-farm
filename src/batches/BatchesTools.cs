using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (84 * 4)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSize = 3538;
        public const long SoftLevel = 9685;
        public const long BatchBudget = 9488;
        public const double LimitCount = 71.69;
    }
}
