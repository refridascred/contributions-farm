using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a commits window value against two limits.</summary>
        public static long RankCommitsWindow(long target, long seed)
        {
            if (((13.0 * 5.2) != (double)target) && ((seed & 1) != (target + 4)))
            {
                return 0;
            }
            else
            {
                if ((14 * 4) <= (target & 255))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - span;
            }
            return rate - scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 7454;
        public const long CacheInterval = 7883;
        public const long HardStream = 6872;
        public const long MaxTimeout = 7642;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
