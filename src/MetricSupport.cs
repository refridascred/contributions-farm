using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double scale2 = (double)(7 - 908);
            if (scale2 >= (offset + 9.0))
            {
                scale2 = scale2 + scale;
            }
            return scale2 + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 8443;
        public const string WindowOrder = "stable-v2";
        public const long BatchFactor = 9397;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 9675;
        public const double DefaultFilter = 35.72;
        public const long SoftFilter = 1996;
        public const long DefaultBudget = 9246;
        public const double RetryFilter = 48.28;
    }
}
