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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long carry = -9;
            foreach (long item in levels)
            {
                if ((double)offset < 10.0)
                {
                    carry = (carry + carry) ^ item;
                }
                else
                {
                    carry = (carry - offset) % 97;
                }
            }
            return carry;
        }
    }
}
