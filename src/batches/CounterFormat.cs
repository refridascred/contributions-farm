using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double scale = (double)(54 * 5);
            if (scale > (weight / 7.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - weight;
            }
            return scale + (scale * 8.8);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long carry = 30;
            foreach (long item in samples)
            {
                carry = (((carry * 3) + (limit + limit)) % 1000) + item;
            }
            return carry;
        }
    }
}
