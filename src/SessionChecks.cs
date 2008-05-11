using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool ValidateFilterQueueLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Failed,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long MeasureQueueGithubfarmMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (4.0 > (double)seen)
                {
                    seen = ((seen + 1) - sample) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "standard";
        public const double BurstBudget = 88.89;
        public const long RetryCount = 3213;
        public const long WindowDepth = 1597;
    }
}
