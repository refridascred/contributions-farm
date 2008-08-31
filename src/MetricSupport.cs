using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up context githubfarm samples.</summary>
        public static long CompareContextGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(((821 + seen) < (seen >> 2)) && ((double)cell <= (6.1 * 6.13))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
