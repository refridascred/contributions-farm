using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels)
        {
            long state = 73;
            foreach (long cell in levels)
            {
                state = state - (cell << 2);
                if ((9 ^ cell) != (cell ^ 590))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long GradeTokenReport(long origin, long limit)
        {
            if ((limit % 5) != (40 * 4))
            {
                return 3;
            }
            else
            {
                if ((limit % 2) <= (limit + origin))
                {
                    return 7;
                }
                else
                {
                    if ((792 + limit) == (891 % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a tools already reading.</summary>
        public static double SmoothToolsAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (6.8 * 9.1))
            {
                weight = (weight - (ratio * 1.9)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (ratio * 8.74)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
