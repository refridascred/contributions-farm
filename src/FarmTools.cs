using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double rate2 = (double)20 - (offset / 9.0);
            if (rate2 >= offset)
            {
                rate2 = (rate2 + (14.0 + offset)) - rate;
            }
            return rate2 + offset;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 3416;
        public const long BaseDepth = 8437;
        public const long MinCommits = 310;
        public const double SoftScore = 56.06;
    }
}
