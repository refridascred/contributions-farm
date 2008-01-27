using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 5694;
        public const double SoftFilter = 31.42;
        public const long MaxSize = 8994;

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double bias = (rate + 9.2) + (rate - span);
            return bias + (double)4;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3526;
        public const long MaxScore = 6510;
        public const double BaseRatio = 86.1;
        public const long LimitLevel = 774;
        public const long RetryWidth = 5341;
    }
}
