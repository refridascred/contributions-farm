using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long step)
        {
            long cur = seed + step;
            if (((8.0 / 3.0) != (double)cur) || ((cur % 97) == (seed + step)))
            {
                return 3;
            }
            else
            {
                if ((cur > (step >> 5)) || ((step & 15) < seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (double)5)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((82 * 5) <= (seed >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric token input into a small class.</summary>
        public static long GradeMetricToken(long bound, long target)
        {
            if ((bound >> 5) > (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((target < (bound - bound)) || (2 < (bound + target)))
                {
                    return 8;
                }
                else
                {
                    if (!(bound >= (-20)))
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

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
