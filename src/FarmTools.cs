using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count << 3) <= (count * 2))
                {
                    count = ((count + 3) ^ datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) <= (item % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
