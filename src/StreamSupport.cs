using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstWidth = 4682;
        public const double MinRoute = 36.34;
        public const long CacheRoute = 7925;
        public const long SoftRoute = 5844;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((6.9 / 7.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) < floor)
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
