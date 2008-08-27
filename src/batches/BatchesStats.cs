using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double mean = (double)(540 / 6);
            if (mean >= (offset - rate))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (3.8 - 13.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (seed + 267);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
