using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next account buffer value from a seed.</summary>
        public static long SeriesAccountBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Queued,
            New,
            Done,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit ^ datum) == (seen ^ limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)step == (16.0 * 9.62)) && (count > (cell + step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
