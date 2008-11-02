using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long target)
        {
            if ((seed / 4) > (seed ^ target))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) > (target + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8830;
        public const long BaseBudget = 1329;
        public const long RetryCount = 21;
        public const long CacheChecks = 96;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen % 12) > (seen + entry)) && (6.2 > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
