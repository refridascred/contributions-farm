using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 9610;
        public const long BurstLevel = 3623;
        public const string RetryInterval = "legacy-v2";
        public const long CacheGithubfarm = 2047;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
