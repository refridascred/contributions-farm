using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long floor)
        {
            if (!((origin & 7) != (floor * 2)))
            {
                return 7;
            }
            else
            {
                if (66 > (floor << 1))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 1) >= 89) || ((8.2 - 8.45) >= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
