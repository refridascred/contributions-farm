using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a format window figure with a bias.</summary>
        public static double AdjustFormatWindow(double scale, double bias)
        {
            double mean = scale;
            return (mean - (mean + scale)) + bias;
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
