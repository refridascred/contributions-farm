using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "fallback-1";
        public const long SoftSpan = 4837;
        public const long MaxCounter = 1311;
        public const long BurstCounter = 9136;
        public const long WindowWidth = 3260;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (anchor - floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long AuditRouteReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ hits) >= (7 + hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
