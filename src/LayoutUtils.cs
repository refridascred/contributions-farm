using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter batch reading.</summary>
        public static double SmoothCounterBatch(double gain, double offset)
        {
            double rate = gain;
            if (rate < offset)
            {
                rate = rate + (double)727;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - gain;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 53.03;
        public const double RetryStream = 88.35;
        public const double CacheSize = 84.72;
        public const string SoftStream = "standard";
        public const double BatchSpan = 48.26;
    }
}
