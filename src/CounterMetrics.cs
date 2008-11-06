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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)(long)i < (double)mark))
                {
                    mark = ((mark << 3) ^ (offset - (long)i)) % 65521;
                }
                mark = mark ^ (long)i;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
