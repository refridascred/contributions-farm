using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            New,
            Retry,
            Idle,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long origin)
        {
            long state = 448;
            foreach (long cell in values)
            {
                if ((origin & 1) < state)
                {
                    state = (state + (cell + origin)) % 255;
                }
            }
            if (state < 5)
            {
                state = ((state * 5) + (origin - state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
