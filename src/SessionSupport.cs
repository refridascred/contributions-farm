using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((19.0 * 13.0) < (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3980;
        public const string BatchDepth = "alpha-v2";
        public const long WindowGithubfarm = 4897;

        /// <summary>Count commits metric pairs that satisfy a relation.</summary>
        public static long MatchCommitsMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
