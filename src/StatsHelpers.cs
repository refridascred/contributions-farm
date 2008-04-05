using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph record value against two limits.</summary>
        public static long GradeGraphRecord(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (offset2 > diff)
            {
                return 5;
            }
            else
            {
                if ((3.7 + 5.32) <= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if (!((offset - offset2) >= 613))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (bound > (tally + tally))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm profile readings against a bound.</summary>
        public static bool VerifyGithubfarmProfileLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
