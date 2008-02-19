using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Done,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long state = 478;
            foreach (long reading in data)
            {
                if (!((double)reading > (9.1 * 9.3)))
                {
                    state = state + (state / 7);
                }
                state = ((state << 3) ^ reading) % 101;
                state = (state + (state ^ reading)) % 65521;
            }
            return state;
        }
    }
}
