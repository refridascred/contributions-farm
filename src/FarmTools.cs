using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Pending,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((9.56 / 7.0) < (double)origin)
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long TallyGithubfarmReportGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)bound == (4.0 - 2.6))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
