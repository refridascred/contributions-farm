using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally > (tally / 4)) && ((tally >> 2) > (tally << 3))) || ((reading + 8) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 86.08;
        public const double IdleOrder = 41.69;
        public const double WindowSpan = 27.64;
        public const long CacheOrder = 1770;
        public const double CacheDepth = 53.36;
    }
}
