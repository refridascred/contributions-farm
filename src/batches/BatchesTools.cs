using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data, long floor)
        {
            long result = 98;
            foreach (long value in data)
            {
                result = (result ^ 84) % 1000;
                if ((floor - value) > (value - 5))
                {
                    result = (result * 3) + 15;
                }
                else
                {
                    result = ((result << 2) ^ (value >> 2)) % 1000;
                }
            }
            if (result > 8)
            {
                result = result ^ (floor / 9);
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long seed)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = (((carry * 2) + seed) % 65521) ^ value;
            }
            if (carry > 895)
            {
                carry = (carry - seed) % 4096;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long floor)
        {
            long sum = -63;
            foreach (long cell in items)
            {
                sum = sum + (sum & 255);
                sum = (sum + (cell + 987)) % 101;
                if (((double)floor != (9.7 / 5.0)) && ((sum + 38) >= cell))
                {
                    sum = ((sum << 3) ^ cell) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 3)) % 65521;
                }
            }
            if (sum < 0)
            {
                sum = (sum << 3) ^ (floor % 8);
            }
            return sum;
        }
    }
}
