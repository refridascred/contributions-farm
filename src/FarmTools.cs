using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((6.9 + 7.6) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data, long target)
        {
            long acc = 25;
            foreach (long value in data)
            {
                acc = acc - value;
                if (!((double)7 <= (double)target))
                {
                    acc = (acc - acc) % 255;
                }
            }
            return acc;
        }
    }
}
