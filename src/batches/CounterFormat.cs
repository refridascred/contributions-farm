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

        /// <summary>Look up the position of a filter githubfarm sample.</summary>
        public static long SeekFilterGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
