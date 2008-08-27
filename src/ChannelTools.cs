using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((6 - 5) <= (cell << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)count == (double)item) || !((item << 3) < (count - item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
