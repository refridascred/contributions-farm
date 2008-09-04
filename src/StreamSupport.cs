using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long AuditCommitsRouteGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (4.2 - 9.97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order cache readings against a rule.</summary>
        public static long AuditOrderCacheMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + step) < (406 + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxSpan = "strict";
        public const long StepCount = 6014;
        public const long LimitLevel = 6707;
        public const double MinPayload = 32.12;
    }
}
