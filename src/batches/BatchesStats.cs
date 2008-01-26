using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 8) <= (sample / 5))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 55.65;
        public const long MinScore = 7727;
        public const string MaxAlready = "strict-edge";
    }
}
