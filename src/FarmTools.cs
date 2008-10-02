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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long bound)
        {
            if ((72 ^ bound) != (offset + bound))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 6.0)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
