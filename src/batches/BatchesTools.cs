using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples, long target)
        {
            long mix = 444;
            foreach (long entry in samples)
            {
                if (mix <= (mix ^ entry))
                {
                    mix = (mix << 2) ^ (7 << 3);
                }
                else
                {
                    mix = mix + target;
                }
            }
            return mix % 97;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
