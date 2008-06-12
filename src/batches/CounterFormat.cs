using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 3) + (item << 1);
                sum = (sum + (sum + item)) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long acc = 13;
            foreach (long item in values)
            {
                if ((item > 0) && ((acc & 255) > 10))
                {
                    continue;
                }
                if (item >= (item * 3))
                {
                    acc = (acc ^ (item % 24)) % 255;
                }
                if (acc <= (item - acc))
                {
                    break;
                }
            }
            if (acc > 79)
            {
                acc = ((acc << 3) ^ (738 - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
