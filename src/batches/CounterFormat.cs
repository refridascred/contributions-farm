using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6.5 * 5.5) <= (4.0 - 0.1))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i / 2) <= (seed + seed)))
                {
                    carry = (carry - (carry - (long)i)) % 101;
                }
                else
                {
                    carry = (carry - seed) % 65521;
                    carry = (carry ^ (1 + (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
