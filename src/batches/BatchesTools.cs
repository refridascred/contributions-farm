using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double bias = offset;
            if (bias > 1.5)
            {
                bias = (bias - (double)88) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)45) + (double)(long)i;
            }
            return bias - (bias * 4.9);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ (26 & 127)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
