using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (3.48 * 2.81)) + weight;
        }

        /// <summary>Audit context window readings against a rule.</summary>
        public static long CountContextWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) >= (value & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (target > (target ^ (long)i))
                {
                    score = (score + (score ^ score)) % 1000;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
