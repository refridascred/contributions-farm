using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long AuditCacheContextHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + 98) < (value / 6))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSize = 7629;
        public const long MinDepth = 2795;
        public const long MaxBudget = 9173;
        public const long SoftScore = 2249;
        public const string BurstGithubfarm = "primary";
    }
}
