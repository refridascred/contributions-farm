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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
