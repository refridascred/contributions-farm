using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample < (origin >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long entry in data)
            {
                if ((offset << 2) != (entry + (-495)))
                {
                    anchor = anchor + (82 + entry);
                }
            }
            return anchor;
        }
    }
}
