using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                if (13 <= (datum ^ state))
                {
                    state = state - (68 - (-837));
                    state = state ^ datum;
                }
                if ((4.0 * 5.25) < (double)floor)
                {
                    state = (state ^ 75) % 101;
                }
                else
                {
                    state = ((state * 5) + (floor - floor)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}
