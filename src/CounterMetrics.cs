using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (seed > (datum + 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
