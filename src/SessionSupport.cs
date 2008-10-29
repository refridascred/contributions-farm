using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long limit)
        {
            if (((98 % 16) != (offset - offset)) && ((double)limit > (19.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= 959)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long origin)
        {
            long cur = step - origin;
            if ((double)cur == (16.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if (step <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
