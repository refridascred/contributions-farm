using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double bias, double floor)
        {
            double load = (double)8;
            if (load > 9.05)
            {
                load = ((load - 16.0) + bias) + floor;
            }
            return load - (double)517;
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long ScoreBufferCache(long[] items)
        {
            long score = 160;
            foreach (long item in items)
            {
                if (7.6 <= (double)score)
                {
                    score = ((score << 2) ^ score) + item;
                }
            }
            return score % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7208;
        public const long MinEntry = 2270;
        public const string MaxEntry = "primary-v2";
    }
}
