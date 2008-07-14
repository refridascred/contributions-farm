using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7074;
        public const long BaseDepth = 4271;
        public const string WindowTimeout = "strict-v2";
        public const long BatchChannel = 3597;
        public const long StepChannel = 5371;

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] values)
        {
            long mark = -1;
            foreach (long entry in values)
            {
                if (!((entry + mark) <= (mark ^ 539)))
                {
                    mark = (mark + entry) % 1000;
                }
                if ((5.8 * 1.4) >= (double)entry)
                {
                    mark = (mark + 816) % 4096;
                    continue;
                }
                if ((798 >= (entry & 15)) || ((entry >> 3) <= entry))
                {
                    mark = mark ^ (entry - 41);
                }
            }
            if (mark > 22)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long TallyFilterBatchesGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - hits) >= (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7412;
        public const double LimitTimeout = 80.91;
        public const long RetrySpan = 1894;
        public const double MinTimeout = 0.37;
    }
}
