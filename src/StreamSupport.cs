using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 6) <= (matches - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
