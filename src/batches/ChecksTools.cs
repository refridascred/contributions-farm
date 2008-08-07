using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (carry + entry)) % 65521) + (long)i;
                }
                if ((double)carry < (double)entry)
                {
                    carry = (carry + (entry << 2)) % 4096;
                }
            }
            if (carry < (-295))
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long acc = 31;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length & 255) != ((-59) + acc)) || ((9.9 * 1.0) != (double)entry))
                {
                    acc = (acc - 9) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Retry,
            Synced,
            Active,
            Closed,
        }
    }
}
