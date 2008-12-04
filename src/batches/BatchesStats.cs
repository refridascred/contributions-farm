using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings)
        {
            long result = 51;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value % 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long floor)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((total ^ value) >= total)
                {
                    total = ((total ^ (value % 3)) % 97) + floor;
                }
            }
            return total % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = ((sum - sum) ^ datum) + seed;
            }
            return sum;
        }
    }
}
