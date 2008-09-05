using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long step)
        {
            if (((double)step != (5.8 * 1.8)) || ((double)step >= (4.25 + 0.58)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) <= (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit report githubfarm readings against a rule.</summary>
        public static long TallyReportGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((18.0 / 2.0) != (double)item) && (((long)samples.Length << 2) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
