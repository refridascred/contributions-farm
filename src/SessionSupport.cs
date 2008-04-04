using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((item % 10) >= hits) || ((hits << 2) > 6)) && (((item >> 1) > (item << 1)) && ((double)hits < (3.0 / 4.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Stale,
            Failed,
            Draft,
        }
    }
}
