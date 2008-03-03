using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((gap - 389) == (bound & 3))
            {
                return 5;
            }
            else
            {
                if (((offset + bound) < (gap + bound)) || ((offset + gap) <= (gap / 3)))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 4) < (gap + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long FoldCommandFormat(long[] values, long target)
        {
            long acc = 38;
            foreach (long sample in values)
            {
                acc = (((acc - (acc % 10)) % 65521) ^ sample) - target;
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }
    }
}
