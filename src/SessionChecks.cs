using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long GradeAccountGithubfarm(long origin, long bound)
        {
            if ((19.0 + 1.0) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin - bound) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((7.63 - 9.0) <= (double)value) && (((limit + tally) > 0) && ((95 + 3) != (value + 19))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Done,
            Failed,
            Synced,
            New,
        }
    }
}
