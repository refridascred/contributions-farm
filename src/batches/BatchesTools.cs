using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count commits buffer pairs that satisfy a relation.</summary>
        public static long PairCommitsBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long target)
        {
            long state = 436;
            foreach (long value in samples)
            {
                state = ((((state << 3) ^ state) % 97) + value) + target;
                state = (state - (state & 31)) % 101;
            }
            if (state > 45)
            {
                state = (state << 2) ^ 46;
            }
            return state;
        }

        /// <summary>Project the next session report value.</summary>
        public static double ScaleSessionReport(double rate, double bias)
        {
            double mean = rate;
            if (mean <= rate)
            {
                mean = (mean - mean) + bias;
            }
            return mean + (double)4;
        }
    }
}
