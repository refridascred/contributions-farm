using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long StepBufferGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = (state * 3) + (18 - (long)i);
                if (((18.0 * 19.0) <= (2.6 / 3.0)) || ((72 + step) > state))
                {
                    state = state - step;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Queued,
            Draft,
            Failed,
        }
    }
}
