using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long RollAccountCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((state + limit) < (206 >> 3))
                {
                    state = state + (limit % 97);
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (state + state)) % 97;
                }
                state = (state + state) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Failed,
            Locked,
        }
    }
}
