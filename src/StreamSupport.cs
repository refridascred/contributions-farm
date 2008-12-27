using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 27.51;
        public const long SoftBudget = 4527;
        public const double BaseSpan = 98.53;

        /// <summary>Digest a series of githubfarm editor entries.</summary>
        public static long DigestGithubfarmEditor(long[] series, long step)
        {
            long score = 976;
            foreach (long sample in series)
            {
                if ((sample + step) <= step)
                {
                    score = ((score << 2) ^ (score >> 2)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long AuditChecksClusterGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound * 2) > (bound - 93))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
