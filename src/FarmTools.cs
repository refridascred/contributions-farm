using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ datum) != (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 6;
            foreach (long cell in samples)
            {
                score = ((score * 2) + (cell & 63)) % 97;
            }
            if (score > 5)
            {
                score = ((score << 3) ^ (score ^ 2)) % 1000;
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double bias)
        {
            double load = (weight + weight) + (5.5 / 8.0);
            if (load > load)
            {
                load = (load - (load + load)) - bias;
            }
            return load + (double)7;
        }
    }
}
