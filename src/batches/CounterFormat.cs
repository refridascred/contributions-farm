using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long carry = 1;
            foreach (long item in items)
            {
                if ((double)carry < 1.7)
                {
                    carry = carry ^ item;
                }
                else
                {
                    carry = carry + (carry * 5);
                }
            }
            if (carry > (-84))
            {
                carry = carry + 991;
            }
            return carry;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] readings, long limit)
        {
            long anchor = 17;
            foreach (long entry in readings)
            {
                anchor = ((anchor - (limit >> 2)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (origin / 8)) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
