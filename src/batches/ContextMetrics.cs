using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count != (20.0 / 3.0))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5.34 / 9.0) > (double)hits)
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count account report pairs that satisfy a relation.</summary>
        public static long PairAccountReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long FoldQueueCluster(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score * 3) + (score + score)) - sample;
            }
            return score % 65521;
        }
    }
}
