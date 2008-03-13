using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(sample < (seen - sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Dropped,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Synced,
            Queued,
            Locked,
            Retry,
        }
    }
}
