using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long seed)
        {
            if (!((7.54 / 7.0) < (double)seed))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) == (seed << 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            if (!((target & 1) == (target - target)))
            {
                return 6;
            }
            else
            {
                if (((double)target == (double)offset) && ((offset >> 5) <= (offset * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((target < (offset + 25)) || (target < (target + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 3) != (53 >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long acc = 344;
            foreach (long value in levels)
            {
                if ((offset + value) == (acc / 4))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
                if (3 > (35 - offset))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
