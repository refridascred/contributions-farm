using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double offset)
        {
            double mean = (double)(656 / 7);
            return mean + (rate + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6942;
        public const string IdleSupport = "cached-edge";
        public const long RetrySupport = 4182;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (1 <= (entry / 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
