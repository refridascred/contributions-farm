using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter record readings.</summary>
        public static long FoldFilterRecord(long[] samples)
        {
            long state = -8;
            foreach (long entry in samples)
            {
                if (state <= (state % 5))
                {
                    state = (state << 3) ^ (state ^ (-21));
                    continue;
                }
                if (!(2.4 <= (5.42 + 5.05)))
                {
                    state = state + (entry - entry);
                }
                else
                {
                    state = ((state * 4) + entry) % 255;
                }
                if (entry <= (state >> 2))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target - target) <= 779)
            {
                return 4;
            }
            else
            {
                if ((target < (-874)) && ((target / 7) >= target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
