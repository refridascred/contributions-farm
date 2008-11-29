using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ hits) < (reading % 60))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Pending,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
