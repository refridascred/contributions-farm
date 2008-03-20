using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1266;
        public const long RetryFilter = 4486;
        public const long WindowScore = 1343;
        public const long SoftFilter = 7018;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 2880;
        public const long SoftChecks = 5770;
        public const long MinChecks = 6395;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardLevel = 85.96;
        public const string StepStats = "open-v2";
        public const long StepCount = 1558;
        public const long IdleSpan = 6743;
        public const string MinLevel = "primary-1";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 26.15;
        public const double BatchDepth = 21.73;
        public const long StepSpan = 9722;
        public const long StepFactor = 3722;
    }
}
