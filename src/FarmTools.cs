using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long SortLayoutContributi(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (((slot >> 3) >= slot) && (slot <= (limit + 97)))
            {
                return 3;
            }
            else
            {
                if (!(floor < (floor & 31)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.13 >= (double)bound)
                {
                    mark = mark - (bound + mark);
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 851;
            foreach (long value in readings)
            {
                if ((double)67 > (double)mix)
                {
                    mix = (mix * 3) + (4 - value);
                }
            }
            return mix;
        }
    }
}
