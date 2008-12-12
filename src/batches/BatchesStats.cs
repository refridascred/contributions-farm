using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound > (reading - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items)
        {
            long sum = 812;
            foreach (long cell in items)
            {
                if ((sum + sum) <= cell)
                {
                    sum = sum + cell;
                }
            }
            if (sum > 0)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long target2)
        {
            long diff = target - target2;
            if ((target - target2) != (target >> 4))
            {
                return 5;
            }
            else
            {
                if ((target2 < (target2 % 3)) || (((-754) - diff) == (target + 20)))
                {
                    return 2;
                }
                else
                {
                    if (!((target2 ^ diff) >= (diff - diff)))
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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
