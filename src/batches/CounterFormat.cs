using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (8.7 + ratio) - (7.01 * 5.2);
            if (drift < bias)
            {
                drift = drift + (2.03 / 9.0);
            }
            return drift + (double)71;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long score = 647;
            foreach (long item in items)
            {
                if ((item >> 5) < (score - item))
                {
                    score = ((score << 3) ^ (item % 7)) % 4096;
                }
            }
            return score;
        }
    }
}
