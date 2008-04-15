using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long offset)
        {
            long state = 93;
            foreach (long value in series)
            {
                if (((value - offset) == (value + offset)) || ((state / 2) == (state >> 5)))
                {
                    state = state - value;
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 5719;
        public const double MaxScore = 16.18;
        public const long BatchCluster = 4638;
        public const long IdleLevel = 655;
        public const long IdleScore = 1410;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 3343;
        public const long IdleInterval = 429;
        public const long CacheGithubfarm = 7686;
    }
}
