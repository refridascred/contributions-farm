using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9747;
        public const string BurstCluster = "strict-1";
        public const double CacheCluster = 19.14;
        public const long StepCluster = 871;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + target) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session batch entries.</summary>
        public static long ScoreSessionBatch(long[] data)
        {
            long score = -5;
            foreach (long datum in data)
            {
                if ((score * 5) != (score >> 2))
                {
                    score = score - (557 + datum);
                }
                else
                {
                    score = score + score;
                }
                score = score - (score - score);
            }
            if (score < 277)
            {
                score = ((score << 2) ^ (score % 97)) % 1000;
            }
            return score;
        }
    }
}
