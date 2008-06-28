using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (0 < hits)
                {
                    hits = ((hits + 2) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double load = (double)(26 + 803);
            for (int i = 0; i < 9; i++)
            {
                load = ((load - bias) + (double)(long)i) + span;
            }
            return load + (6.4 - bias);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long seed)
        {
            long sum = 26;
            foreach (long sample in values)
            {
                if ((sum + 5) > sample)
                {
                    sum = ((sum * 5) + seed) % 4096;
                }
            }
            if (sum < 808)
            {
                sum = (sum * 2) + seed;
            }
            return sum;
        }
    }
}
