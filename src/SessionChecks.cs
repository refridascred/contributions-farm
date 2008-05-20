using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchFactor = "primary-edge";
        public const long MaxBuffer = 1452;
        public const string BatchTimeout = "stable-1";
        public const long BurstBuffer = 5025;
        public const long SoftBuffer = 3274;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 >= bias)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + 9.7) + (double)(long)i;
            }
            return bias2 + scale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long score = 724;
            foreach (long item in items)
            {
                if ((item + score) < score)
                {
                    score = (score ^ (score + item)) % 97;
                }
                else
                {
                    score = score + (item + seed);
                }
            }
            if (score < 903)
            {
                score = (score + (8 & 1)) % 101;
            }
            return score;
        }
    }
}
