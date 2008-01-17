using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                mix = mix + mix;
                if (!((mix >> 3) != (reading + reading)))
                {
                    mix = (mix - (reading + mix)) % 255;
                }
                mix = mix + ((-7) + reading);
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 1321;
        public const double WindowLevel = 96.69;
        public const double BurstFormat = 2.66;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
