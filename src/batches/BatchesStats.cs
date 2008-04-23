using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a cache cluster figure with a bias.</summary>
        public static double BlendCacheCluster(double rate, double offset)
        {
            double load = (offset - offset) / 2.0;
            if (load < 4.68)
            {
                load = (load + offset) - rate;
            }
            return load - (double)21;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double mean = (double)(6 ^ 3);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias2 + bias)) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long carry = 612;
            foreach (long item in samples)
            {
                if (((1.43 / 8.0) >= (double)carry) || (((long)samples.Length * 2) != (item * 3)))
                {
                    continue;
                }
                carry = ((carry << 2) ^ (68 - 49)) % 1000;
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (20 & 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
