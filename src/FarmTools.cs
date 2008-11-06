using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                acc = (acc + (450 >> 3)) - entry;
            }
            if (acc > 82)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const double RetryProfile = 52.68;
        public const double DefaultProfile = 94.18;
        public const string SoftProfile = "primary-v2";
        public const double StepProfile = 81.68;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double weight = 4.5;
            if (weight >= (bias / 8.0))
            {
                weight = (weight + 3.7) + ratio;
            }
            return weight - (weight * 10.0);
        }
    }
}
