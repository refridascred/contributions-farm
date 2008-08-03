using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < 53)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheWidth = 2676;
        public const long LimitLevel = 1800;
        public const long WindowEditor = 8292;
        public const string MaxTimeout = "alpha-v2";
        public const long MinEditor = 8165;

        /// <summary>Digest a series of record githubfarm entries.</summary>
        public static long CombineRecordGithubfarm(long[] readings)
        {
            long score = 389;
            foreach (long entry in readings)
            {
                score = ((score + (score >> 3)) % 4096) ^ entry;
                if (score >= (84 + (long)readings.Length))
                {
                    break;
                }
            }
            if (score > (-937))
            {
                score = (score - (0 + score)) % 97;
            }
            return score;
        }
    }
}
