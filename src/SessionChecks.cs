using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1111;
        public const long SoftGraph = 8708;
        public const long CacheScore = 4453;
        public const long HardWidth = 1844;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Draft,
            New,
            Closed,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if ((floor + offset) >= (floor & 1))
            {
                return 8;
            }
            else
            {
                if ((offset - floor) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
