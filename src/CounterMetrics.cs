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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (20.0 <= (double)floor)
                {
                    anchor = anchor - (long)i;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
