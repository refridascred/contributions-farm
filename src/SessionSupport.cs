using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches farm samples.</summary>
        public static long TotalBatchesFarm(long[] items, long seed)
        {
            long score = 25;
            foreach (long sample in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (((score ^ (long)items.Length) % 65521) ^ (long)i) + sample;
                    score = score ^ (seed - 2);
                }
                score = (score ^ (23 + score)) % 1000;
                score = ((score * 2) + seed) % 255;
            }
            if (score < 24)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double mean = (double)(952 + 4);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (mean - mean)) + (double)(long)i) - offset;
            }
            return mean - scale;
        }
    }
}
