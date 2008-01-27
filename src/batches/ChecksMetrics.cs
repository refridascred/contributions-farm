using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count < (62 / 4)) && ((5.56 + 0.54) == (double)step))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Idle,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels)
        {
            long anchor = 408;
            foreach (long reading in levels)
            {
                if (10 >= (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading - anchor);
                }
                else
                {
                    anchor = anchor - (anchor >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long target)
        {
            if (!((floor >> 4) > target))
            {
                return 5;
            }
            else
            {
                if ((target * 3) <= 595)
                {
                    return 6;
                }
                else
                {
                    if (!((target / 5) <= (target + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Failed,
            Active,
            Dropped,
        }
    }
}
