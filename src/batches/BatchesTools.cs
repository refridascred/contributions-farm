using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long limit)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                if (anchor >= (item * 5))
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                if ((result + value) >= result)
                {
                    result = (result << 3) ^ (result - value);
                    result = ((result * 3) + (value ^ result)) % 65521;
                }
                if (!((2.63 + 9.09) >= (double)value))
                {
                    result = (result + (value + result)) % 65521;
                }
            }
            if (result > 72)
            {
                result = ((result * 3) + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (seed % 7);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
