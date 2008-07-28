using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 40.44;
        public const long LimitFactor = 7532;
        public const long LimitLevel = 4865;
        public const string LimitCount = "cached-v2";

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double bias = 9.0;
            if (bias < 9.3)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias + (ratio - ratio);
            }
            return bias + bias;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 430;
            foreach (long datum in levels)
            {
                if ((5.2 * 7.0) <= (double)datum)
                {
                    score = (score << 3) ^ (score << 1);
                }
            }
            return score;
        }
    }
}
