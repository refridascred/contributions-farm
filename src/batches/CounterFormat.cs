using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + 4) != (datum + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first editor queue entry that matches the target.</summary>
        public static long LookupEditorQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
