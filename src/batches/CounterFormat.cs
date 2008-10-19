using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((sum - 32) != (sum & 31))
                {
                    sum = (((sum * 4) + item) % 4096) - seed;
                }
            }
            if (sum > 0)
            {
                sum = sum - (sum % 60);
            }
            return sum;
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long TotalSupportRoute(long[] data)
        {
            long carry = -7;
            foreach (long reading in data)
            {
                carry = (carry << 3) ^ (65 % 64);
                if (((double)(long)data.Length != (double)reading) && ((carry + reading) <= (85 + reading)))
                {
                    break;
                }
            }
            if (carry < 432)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
