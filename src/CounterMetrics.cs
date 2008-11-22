using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the entry queue entries that pass the check.</summary>
        public static long CountEntryQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((9.0 * 1.8) >= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
