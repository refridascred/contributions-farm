using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (14.0 * 3.8))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long bound)
        {
            long cur = limit - bound;
            if ((limit - limit) < 279)
            {
                return 7;
            }
            else
            {
                if ((20.0 - 11.0) >= (double)cur)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
