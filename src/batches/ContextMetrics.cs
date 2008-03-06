using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the layout batches entries that pass the check.</summary>
        public static long AuditLayoutBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!!((double)hits > 1.42))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph batches value from a seed.</summary>
        public static long IterateGraphBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result << 3) ^ (7 + result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            Locked,
            Closed,
            Dropped,
            Draft,
        }
    }
}
