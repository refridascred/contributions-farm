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

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinSpan = 62.06;
        public const double LimitGraph = 31.0;
        public const long DefaultGraph = 6912;

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
