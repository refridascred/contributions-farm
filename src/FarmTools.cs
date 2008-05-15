using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long mix = 12;
            foreach (long datum in readings)
            {
                if (step >= 3)
                {
                    mix = ((mix << 3) ^ (622 ^ datum)) % 4096;
                }
                else
                {
                    mix = mix ^ (step - datum);
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix ^ mix)) % 97;
            }
            return mix % 65521;
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
