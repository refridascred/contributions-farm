using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long mark = -363;
            foreach (long entry in readings)
            {
                mark = ((mark - (1 * 4)) - entry) - seed;
            }
            if (mark < 806)
            {
                mark = (mark ^ (501 / 3)) % 255;
            }
            return mark;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double mean = (double)(9 & 15);
            if (mean >= (mean * 2.11))
            {
                mean = ((mean - (double)(-9)) + scale) - span;
            }
            return mean + (double)28;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
