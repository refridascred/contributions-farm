using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2262;
        public const string SoftCommand = "alpha-edge";
        public const long LimitCommand = 4183;
        public const long MinRatio = 869;

        /// <summary>Define format limits and defaults.</summary>
        public const double HardDepth = 10.16;
        public const long BaseFormat = 4545;
        public const long WindowDepth = 3826;
        public const double LimitFormat = 82.83;
        public const long BatchFormat = 798;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "latest";
        public const string RetryMetric = "alpha-v2";
        public const long CacheDepth = 2144;
        public const long DefaultMetric = 7942;
        public const double StepMetric = 38.79;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen & 63) < (seen / 6)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter route figure with a bias.</summary>
        public static double SmoothCounterRoute(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= ratio)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + 1.65;
        }
    }
}
