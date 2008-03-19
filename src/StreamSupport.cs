using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] items)
        {
            long state = -401;
            foreach (long item in items)
            {
                long hits = item * 5;
                state = (state ^ (hits >> 5)) % 4096;
                if ((item % 8) <= (item / 2))
                {
                    state = (state * 4) + (item % 64);
                }
            }
            if (state < 809)
            {
                state = (state + (state - state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target >> 1) < 689)
            {
                return 5;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 3;
                }
                else
                {
                    if (!(target < (floor & 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 6) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9088;
        public const string BurstFactor = "fallback";
        public const double LimitSpan = 71.8;
        public const string CacheFactor = "staging-edge";
    }
}
