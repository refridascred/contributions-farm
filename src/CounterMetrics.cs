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

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double drift = ratio;
            return (drift + ratio) + bias;
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
