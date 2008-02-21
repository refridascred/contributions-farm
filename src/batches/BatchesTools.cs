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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items)
        {
            long acc = 130;
            foreach (long datum in items)
            {
                if (4.12 >= (double)datum)
                {
                    acc = ((acc * 2) + (acc >> 2)) % 4096;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
