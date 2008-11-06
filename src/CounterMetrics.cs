using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3467;
        public const double MinMetrics = 95.94;
        public const string StepScore = "stable-v2";
        public const long CacheMetrics = 717;
        public const long MaxMetrics = 1359;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long limit)
        {
            long mark = 677;
            foreach (long datum in readings)
            {
                mark = (mark + (datum ^ mark)) % 1000;
                if ((mark >> 4) >= limit)
                {
                    break;
                }
            }
            if (mark < 62)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry > tally) && (0.4 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long bound)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                acc = acc ^ (item ^ item);
            }
            if (acc > 20)
            {
                acc = acc ^ (bound * 4);
            }
            return acc;
        }
    }
}
