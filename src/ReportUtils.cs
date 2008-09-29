using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5330;
        public const double CacheWindow = 80.51;
        public const long MaxWindow = 9107;
        public const long RetryWindow = 4874;
        public const long StepWindow = 9462;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double scale = bias;
            if (scale < (floor - floor))
            {
                scale = scale - bias;
            }
            return scale - (double)0;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
