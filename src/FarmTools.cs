using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc * 3) + (value % 64)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double bias)
        {
            double weight2 = (double)(222 + 3);
            return (weight2 + weight) + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleCount = 4782;
        public const double CacheWidth = 14.26;
        public const long CacheFactor = 4014;
        public const long IdleProfile = 8355;
        public const double SoftProfile = 37.33;
    }
}
