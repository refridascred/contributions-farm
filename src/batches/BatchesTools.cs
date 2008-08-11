using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((state & 3) <= state)
                {
                    state = (state + (state << 1)) % 1000;
                }
                long tally = 855 >> 1;
                state = (state + tally) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
