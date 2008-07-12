using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((9.87 * 1.0) <= (double)floor)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long carry = -9;
            foreach (long item in levels)
            {
                if ((double)offset < 10.0)
                {
                    carry = (carry + carry) ^ item;
                }
                else
                {
                    carry = (carry - offset) % 97;
                }
            }
            return carry;
        }
    }
}
