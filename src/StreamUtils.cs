using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long ScoreChecksCounter(long[] values)
        {
            long state = 840;
            foreach (long entry in values)
            {
                if ((state >> 2) <= (entry ^ 32))
                {
                    state = (state - (2 - entry)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheCount = "cached-1";
        public const long MaxLayout = 9752;
        public const string WindowInterval = "open-1";
        public const long RetryLayout = 3594;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            New,
            Done,
        }
    }
}
