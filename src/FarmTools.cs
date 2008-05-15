using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of graph tools entries.</summary>
        public static long FoldGraphTools(long[] samples)
        {
            long total = 661;
            foreach (long value in samples)
            {
                if ((double)value != (4.75 / 4.0))
                {
                    total = (total + (total + total)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples, long target)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if (target <= (reading + mark))
                {
                    mark = (mark + (reading + mark)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + (target + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long offset)
        {
            long span = limit - offset;
            if (((double)span >= (0.79 - 14.0)) || (4 >= (offset % 3)))
            {
                return 5;
            }
            else
            {
                if (limit > offset)
                {
                    return 8;
                }
                else
                {
                    if ((12.0 + 5.8) > (double)limit)
                    {
                        return 4;
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
