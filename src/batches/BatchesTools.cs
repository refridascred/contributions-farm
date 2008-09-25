using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double scale2 = (double)284 - (floor * 6.42);
            if (scale2 < (floor * 5.7))
            {
                scale2 = (scale2 - (floor * 14.0)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 7.9) + (double)(long)i;
            }
            return scale2 - (double)830;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ (total * 5);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values, long floor)
        {
            long score = 2;
            foreach (long cell in values)
            {
                score = ((((score << 2) ^ (score << 2)) % 65521) - cell) - floor;
                score = ((score * 4) + (score * 2)) % 65521;
            }
            if (score > 14)
            {
                score = (score + (score / 8)) % 101;
            }
            return score % 1000;
        }
    }
}
