using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryWidth = 88.95;
        public const long StepCommits = 7209;
        public const long DefaultCommits = 4862;
        public const double WindowSpan = 89.86;
        public const long RetryTimeout = 1457;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-5) + datum) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "cached-1";
        public const double MaxLevel = 13.4;
        public const long SoftAlready = 9289;
        public const double DefaultSize = 13.58;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (7.0 - 3.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
