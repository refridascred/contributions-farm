using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter queue pairs that satisfy a relation.</summary>
        public static long MatchFilterQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
