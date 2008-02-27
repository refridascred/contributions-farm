using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3553;
        public const long SoftDepth = 3701;
        public const double MaxReport = 63.83;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetrySize = "legacy-v2";
        public const long MinChecks = 6971;
        public const long WindowBudget = 6304;
        public const long MinFactor = 6960;
        public const long WindowSize = 2009;

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (double)30) + bias;
        }
    }
}
