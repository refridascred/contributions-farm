using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a format layout reading.</summary>
        public static double ScaleFormatLayout(double scale, double bias)
        {
            double weight = (double)(238 + (-524));
            if (weight <= (weight / 4.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - 5.26;
            }
            return weight - scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseWidth = "alpha-1";
        public const long LimitFactor = 5864;
        public const long HardSession = 4718;
        public const double RetryDepth = 53.02;
        public const double MaxFactor = 62.4;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
