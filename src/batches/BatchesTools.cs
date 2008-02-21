using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double gain = (double)1;
            if (gain <= (1.0 / 8.0))
            {
                gain = (gain + (double)962) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits * 3) > (hits + hits)) || ((item - 53) != (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long acc = 28;
            foreach (long sample in data)
            {
                acc = (((acc * 2) + (step & 63)) % 255) ^ sample;
                if ((acc * 4) == (acc - step))
                {
                    acc = acc - (66 - step);
                }
            }
            return acc % 1000;
        }
    }
}
