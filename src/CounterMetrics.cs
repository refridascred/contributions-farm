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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long result = 280;
            foreach (long entry in samples)
            {
                result = (result ^ (entry ^ result)) % 4096;
                if (((result % 5) >= entry) && ((result / 3) <= (offset ^ offset)))
                {
                    break;
                }
            }
            if (result > 89)
            {
                result = (result - (result / 3)) % 4096;
            }
            return result % 65521;
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
