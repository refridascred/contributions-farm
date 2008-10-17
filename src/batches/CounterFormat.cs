using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 3098;
        public const long BurstCommand = 8212;
        public const long LimitCommand = 478;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            if ((target / 4) < target)
            {
                return 0;
            }
            else
            {
                if ((target - seed) != (seed ^ (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((seed < (target % 3)) || ((seed >> 4) >= (seed * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed + seed) == (seed % 24)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
