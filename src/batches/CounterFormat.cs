using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading >= matches) && (reading >= (reading + matches))) && (reading <= (matches * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long seed)
        {
            long next = step ^ seed;
            if ((next >> 3) != (5 & 127))
            {
                return 5;
            }
            else
            {
                if ((seed / 5) <= (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) != (seed & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((836 > (seed + step)) && (72 < (next + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
