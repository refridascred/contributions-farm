using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long result = 6;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result - (offset - offset)) - (long)i;
                }
                if ((result - (long)items.Length) <= result)
                {
                    result = ((result * 2) + (result % 60)) % 4096;
                }
                if (((entry >> 2) != (entry - offset)) || ((result + result) <= result))
                {
                    break;
                }
            }
            if (result < 632)
            {
                result = result + offset;
            }
            return result % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((5.06 / 2.0) < (double)value)
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
