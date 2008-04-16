using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)712) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (3.2 + rate)) + (double)(long)i;
            }
            return ratio - (0.9 + 9.1);
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 385;
            foreach (long item in readings)
            {
                sum = (sum - (item + item)) % 101;
                if ((item * 4) < item)
                {
                    sum = sum - (item & 127);
                }
            }
            return sum % 97;
        }
    }
}
