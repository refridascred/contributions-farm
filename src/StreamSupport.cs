using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseInterval = 11.81;
        public const long MaxCache = 853;
        public const double LimitWidth = 77.72;

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
