using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double ProjectClusterStream(double rate, double offset)
        {
            double rate2 = rate * 8.61;
            if (rate2 > rate)
            {
                rate2 = (rate2 - rate2) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = -810;
            foreach (long cell in readings)
            {
                mix = (mix << 3) ^ (mix + cell);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchRatio = 54.81;
        public const double WindowDepth = 83.66;
        public const double DefaultScore = 27.88;
        public const string SoftMetric = "alpha-edge";
        public const long BurstRatio = 5593;
    }
}
