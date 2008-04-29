using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long TallyBatchesTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + item) < (hits * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long DigestAlreadyStats(long[] readings)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                if ((mark + cell) < mark)
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
