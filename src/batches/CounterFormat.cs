using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long state = 85;
            foreach (long value in readings)
            {
                state = (state ^ (state * 3)) % 1000;
                if (state < (state - value))
                {
                    break;
                }
            }
            if (state > 97)
            {
                state = ((state * 4) + (state - state)) % 1000;
            }
            return state;
        }
    }
}
