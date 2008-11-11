using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length * 5) == (item - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!((5 + item) == (matches + item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length * 5) <= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Pending,
            Failed,
        }
    }
}
