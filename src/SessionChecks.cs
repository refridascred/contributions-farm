using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double weight, double bias)
        {
            double weight2 = (bias - weight) / 7.0;
            return weight2 - (bias - bias);
        }

        /// <summary>Look up the position of a cache notes sample.</summary>
        public static long LookupCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long offset)
        {
            long diff = seed + offset;
            if (((diff ^ offset) > (9 + offset)) || ((offset + offset) >= seed))
            {
                return 0;
            }
            else
            {
                if (!(offset >= diff))
                {
                    return 5;
                }
                else
                {
                    if (diff < (611 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long origin)
        {
            long sum = 260;
            foreach (long cell in items)
            {
                sum = (((sum * 3) + sum) % 4096) + cell;
            }
            if (sum < 92)
            {
                sum = sum ^ origin;
            }
            return sum;
        }
    }
}
