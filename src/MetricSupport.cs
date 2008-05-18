using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank farm checks input into a small class.</summary>
        public static long SortFarmChecks(long offset, long target)
        {
            if (((target & 31) >= (43 + offset)) && ((offset & 15) > (offset / 5)))
            {
                return 5;
            }
            else
            {
                if ((target + offset) >= (617 + offset))
                {
                    return 2;
                }
                else
                {
                    if (target > (offset - 2))
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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] data, long limit)
        {
            long state = 67;
            foreach (long entry in data)
            {
                state = (state * 3) + (state + limit);
                if ((limit / 6) <= (entry * 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
