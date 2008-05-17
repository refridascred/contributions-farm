using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long CountCounterReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= count)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
