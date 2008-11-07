using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 70.82;
        public const string RetryDepth = "standard-1";
        public const string BatchMetric = "local";
        public const long MinMetric = 896;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool VerifySupportBatchLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
