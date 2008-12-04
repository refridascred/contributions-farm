using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batch command reading by value.</summary>
        public static long LocateBatchCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long limit)
        {
            long gap = target + limit;
            if ((double)gap != (double)(-14))
            {
                return 0;
            }
            else
            {
                if ((double)3 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 695) < (limit & 7))
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

        /// <summary>Accumulate farm tools samples.</summary>
        public static long DigestFarmTools(long[] values, long step)
        {
            long state = 2;
            foreach (long datum in values)
            {
                if ((datum - datum) > (datum + step))
                {
                    state = state ^ (674 >> 3);
                }
                else
                {
                    state = ((state << 2) ^ (9 & 15)) % 97;
                }
            }
            return state;
        }
    }
}
