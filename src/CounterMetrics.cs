using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long GradeBufferCache(long step, long limit)
        {
            long offset = step ^ limit;
            if ((offset > (limit + limit)) || ((offset & 1) <= (offset - 43)))
            {
                return 8;
            }
            else
            {
                if (((double)limit < (9.92 / 8.0)) || ((limit + 386) == (limit - offset)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Closed,
            New,
            Stale,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long AuditReportMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((entry < (matches % 5)) || ((489 + 51) >= (matches ^ matches))) || ((8.6 - 12.0) != (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
