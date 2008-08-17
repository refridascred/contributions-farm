using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double drift = (scale / 6.0) * 9.09;
            if (drift >= drift)
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias / 6.0)) + (double)(long)i;
            }
            return drift - (20.0 / 6.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6139;
        public const long BurstCount = 474;
        public const long StepFactor = 5082;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples)
        {
            long anchor = 193;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length ^ cell) < cell))
                {
                    anchor = ((anchor << 3) ^ (anchor >> 1)) % 255;
                }
                if ((573 ^ anchor) == (anchor % 2))
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 31)) % 1000;
                }
                if (!((55 << 2) == (anchor / 8)))
                {
                    break;
                }
            }
            if (anchor > 78)
            {
                anchor = (anchor - (anchor << 3)) % 101;
            }
            return anchor;
        }
    }
}
