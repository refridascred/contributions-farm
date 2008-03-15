using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate report order readings against a bound.</summary>
        public static bool ValidateReportOrderBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits != (14.0 + 0.04))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9104;
        public const string BatchReport = "cached-edge";
        public const long BurstReport = 5484;
        public const string StepReport = "cached-v2";
        public const long MaxReport = 7148;

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryBudget = "local-v2";
        public const long MinCommits = 8872;
        public const string LimitCommits = "local-v2";
    }
}
