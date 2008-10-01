using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 7075;
        public const long SoftRoute = 6272;
        public const double BurstScore = 5.39;
        public const long RetryWidth = 6929;

        /// <summary>Check that every route cluster entry stays within the limit.</summary>
        public static bool GuardRouteClusterLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long CountClusterOrderGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value << 2) <= (value << 1))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
