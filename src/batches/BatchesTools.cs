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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
