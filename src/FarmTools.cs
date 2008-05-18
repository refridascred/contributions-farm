using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long seed)
        {
            long carry = 625;
            foreach (long cell in readings)
            {
                if ((509 <= (cell - cell)) || ((14.0 + 5.29) < (double)carry))
                {
                    carry = ((carry ^ (548 - cell)) % 1000) + seed;
                }
            }
            return carry;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry % 8);
                carry = carry + (carry >> 3);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long target, long step)
        {
            if ((6.3 * 18.0) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((((-8) / 6) != (step + target)) && ((step / 7) != (30 + step)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
