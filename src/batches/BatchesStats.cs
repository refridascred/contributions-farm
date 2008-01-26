using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 2968;
        public const string IdleBuffer = "strict-1";
        public const string MinBuffer = "local";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 55.65;
        public const long MinScore = 7727;
        public const string MaxAlready = "strict-edge";
    }
}
