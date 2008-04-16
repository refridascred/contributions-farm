using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 538;
        public const double BurstOrder = 1.42;
        public const long CacheWidth = 1737;
        public const double HardRatio = 44.68;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 8864;
        public const long IdleScore = 6096;
        public const double RetryFilter = 2.77;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double ratio2 = (ratio / 9.0) + ratio;
            if (ratio2 > (double)9)
            {
                ratio2 = (ratio2 - (ratio + ratio2)) - offset;
            }
            return ratio2 + (ratio * 5.7);
        }
    }
}
