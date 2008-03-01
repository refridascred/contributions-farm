using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long mix = 6;
            foreach (long cell in values)
            {
                mix = (mix ^ 84) + cell;
            }
            return mix;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long SortTokenQueue(long step, long seed)
        {
            long prev = step + seed;
            if (((step << 2) == (prev - seed)) && (348 > (419 ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((0.3 + 9.7) <= (double)seed) && ((step ^ seed) == (seed * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) > 11)
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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
