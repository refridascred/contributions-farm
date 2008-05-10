using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 16.73;
        public const string RetryScore = "stable";
        public const string SoftSize = "stable-1";
        public const long CacheRatio = 1443;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
