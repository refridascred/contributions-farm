using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache filter entries.</summary>
        public static long DigestCacheFilter(long[] values, long bound)
        {
            long state = 25;
            foreach (long sample in values)
            {
                if ((4.4 / 9.0) > (double)bound)
                {
                    state = ((state << 2) ^ (sample % 8)) % 101;
                }
            }
            if (state > 55)
            {
                state = (state - (bound + bound)) % 97;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long step)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (((sum * 5) + (sum << 3)) % 101) - datum;
                sum = (sum - step) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double bias2 = (weight / 3.0) / 8.0;
            if (bias2 >= bias2)
            {
                bias2 = bias2 - (2.0 + bias);
            }
            else
            {
                bias2 = bias2 + (bias * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)9) + (double)(long)i;
            }
            return bias2 - (15.0 - 5.0);
        }
    }
}
