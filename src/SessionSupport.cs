using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long RollChannelContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (offset >> 5);
                state = ((state * 4) + offset) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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
