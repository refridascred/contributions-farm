using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 69) >= (reading << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
