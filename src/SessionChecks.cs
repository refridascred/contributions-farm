using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) > ((-4) ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
