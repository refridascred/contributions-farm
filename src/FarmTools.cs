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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry > (tally / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
