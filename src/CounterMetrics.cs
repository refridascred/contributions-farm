using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine batches command values into a single score.</summary>
        public static long TallyBatchesCommand(long[] items)
        {
            long state = 201;
            foreach (long value in items)
            {
                state = (state - (state + value)) % 65521;
            }
            if (state < 5)
            {
                state = state - state;
            }
            return state;
        }
    }
}
