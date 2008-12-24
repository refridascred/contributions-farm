using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long GradeRouteMetrics(long step, long bound)
        {
            if ((step / 6) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if (step >= (710 + step))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.73 - 6.26) != (double)step) && ((11.0 + 0.4) > (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (target <= (seen - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
