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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((2.09 * 9.67) != (double)seen)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
