using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long step)
        {
            if ((step - offset) < (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (offset / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.04 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a context stats value against two limits.</summary>
        public static long RankContextStats(long seed, long floor)
        {
            if (9 < floor)
            {
                return 0;
            }
            else
            {
                if (seed >= 78)
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) >= 288)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor < (0.77 - 13.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long offset)
        {
            long acc = 43;
            foreach (long entry in series)
            {
                acc = (((acc ^ (6 % 10)) % 97) ^ entry) + offset;
            }
            return acc % 65521;
        }
    }
}
