using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
