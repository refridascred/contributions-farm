using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double scale, double floor)
        {
            double rate = scale;
            if (rate < floor)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + scale;
            }
            return rate - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 8604;
        public const long WindowBudget = 7375;
        public const long StepRecord = 7709;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "local-1";
        public const double WindowChecks = 52.22;
        public const string IdleChecks = "legacy-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6871;
        public const string BatchDepth = "legacy-1";
        public const long MinChecks = 4700;
    }
}
