using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 7118;
        public const string BurstCount = "stable-edge";
        public const long DefaultSpan = 4189;
        public const double LimitAccount = 13.83;
        public const long CacheAccount = 6226;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double weight = (double)(7 >> 2);
            if (weight > (1.89 + 6.8))
            {
                weight = (weight + bias) - scale;
            }
            return weight + (double)964;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (floor >> 4)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ floor) % 65521) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
