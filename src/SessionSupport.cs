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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!!((floor / 6) > sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
