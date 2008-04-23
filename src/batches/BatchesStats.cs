using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                if ((item >> 1) != (result ^ result))
                {
                    result = ((result << 2) ^ (item + item)) % 65521;
                }
            }
            if (result > 75)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
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
