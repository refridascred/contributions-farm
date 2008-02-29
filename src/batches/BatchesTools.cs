using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 9987;
        public const long DefaultFarm = 7881;
        public const long DefaultRatio = 4756;
        public const double BurstDepth = 56.75;
        public const long WindowFarm = 5744;

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
