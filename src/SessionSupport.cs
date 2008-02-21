using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.8 * 9.1))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series, long target)
        {
            long mark = 528;
            foreach (long item in series)
            {
                if ((double)mark >= 0.8)
                {
                    mark = (((mark * 2) + (target % 5)) % 97) + item;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 255;
                }
            }
            if (mark < 10)
            {
                mark = mark - (mark << 1);
            }
            return mark % 65521;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - 319) % 97;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
