using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long BucketMetricsQueue(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step3 < (step2 >> 3)) && (step2 < (step2 - step3)))
            {
                return 7;
            }
            else
            {
                if ((step3 / 7) < step)
                {
                    return 2;
                }
                else
                {
                    if (step3 >= (step % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally / 6) != (cell * 3)) && ((1 >> 5) < (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long CountRouteGithubfarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((881 + 3) == (limit & 1))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Failed,
            Synced,
            Stale,
        }
    }
}
