using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((origin & 3) <= (bound / 8))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) > (origin & 127))
                {
                    return 2;
                }
                else
                {
                    if (((69 - origin) == (origin + origin)) || ((origin % 3) <= (origin + 73)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Draft,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item <= (matches ^ (long)values.Length)) || (matches <= (item - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Fold a list of graph channel readings.</summary>
        public static long TotalGraphChannel(long[] values, long step)
        {
            long sum = 20;
            foreach (long cell in values)
            {
                if (((double)sum > 8.69) && ((cell + sum) >= (sum * 4)))
                {
                    sum = ((sum << 3) ^ cell) + step;
                }
                else
                {
                    sum = (sum << 2) ^ (sum >> 2);
                }
            }
            return sum % 1000;
        }
    }
}
