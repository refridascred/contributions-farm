using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long AuditLayoutMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((entry & 31) <= seen) || ((double)entry < (double)9)) || ((double)entry < (7.95 / 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5519;
        public const long DefaultDepth = 8296;
        public const string DefaultTimeout = "cached-1";
        public const long BurstTimeout = 4531;
        public const long MaxInterval = 6172;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count & 15) != (count / 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
