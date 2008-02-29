using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (double)79)
            {
                scale2 = (scale2 - (scale * 17.0)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale / 5.0)) + (double)(long)i;
            }
            return scale2 + (double)9;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double scale = rate + span;
            if (scale <= (scale - scale))
            {
                scale = scale + rate;
            }
            return scale - rate;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "alpha-v2";
        public const long LimitDepth = 62;
        public const string BurstCommits = "primary-edge";
        public const long LimitCommits = 7841;
    }
}
