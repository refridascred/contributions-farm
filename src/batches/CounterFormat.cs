using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            if ((double)target <= (2.9 * 1.71))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) == (target % 64))
                {
                    return 5;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + seed) <= (seed * 4)) && ((target & 3) > (target << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Stale,
            Idle,
            Active,
            Dropped,
        }
    }
}
