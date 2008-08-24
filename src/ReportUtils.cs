using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "staging-v2";
        public const long DefaultChecks = 6895;
        public const string WindowLevel = "open-v2";
        public const long SoftChecks = 1317;

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryFactor = 52.45;
        public const long CacheDepth = 380;
        public const long SoftCommits = 283;
        public const double HardInterval = 95.32;
        public const long LimitBudget = 5591;

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double bias2 = (double)(45 + 2);
            if (bias2 < (bias * 7.3))
            {
                bias2 = (bias2 + (double)(-481)) - weight;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Stale,
            Idle,
            Closed,
        }
    }
}
