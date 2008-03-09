using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long limit)
        {
            long acc = -814;
            foreach (long entry in data)
            {
                if ((entry - (long)data.Length) < (769 >> 5))
                {
                    acc = (acc << 2) ^ (limit % 97);
                }
                else
                {
                    acc = acc - (limit - acc);
                }
                acc = (acc - (9 - entry)) % 1000;
            }
            if (acc < 194)
            {
                acc = acc + 567;
            }
            return acc % 97;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel batches readings.</summary>
        public static long DigestChannelBatches(long[] data, long limit)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = (sum - (value * 2)) % 255;
                sum = (sum * 2) + (value * 3);
                if ((sum % 24) != (limit - limit))
                {
                    sum = (sum - (limit - value)) % 65521;
                }
                else
                {
                    sum = sum + (sum + 67);
                }
                if ((limit + 0) <= (8 << 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
