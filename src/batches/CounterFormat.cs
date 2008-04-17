using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value > (value % 24)) || !((4.47 * 5.0) > (double)value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session token entries.</summary>
        public static long WeighSessionToken(long[] data)
        {
            long score = 12;
            foreach (long value in data)
            {
                score = score + value;
            }
            return score;
        }
    }
}
