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

        /// <summary>Count cache editor pairs that satisfy a relation.</summary>
        public static long PairCacheEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 7) < (-71))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
