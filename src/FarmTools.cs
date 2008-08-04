using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long CountCounterSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 * 2) >= (limit - item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 994;
        public const string DefaultTimeout = "latest";
        public const long RetryChecks = 5754;
        public const string BaseInterval = "fallback-edge";
    }
}
