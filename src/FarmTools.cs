using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a entry layout counter forward.</summary>
        public static long RollEntryLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                long prev = origin;
                state = ((state * 5) + (state - state)) % 65521;
                if (prev < ((long)i * 5))
                {
                    prev = prev ^ state;
                    state = (state * 4) + state;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long offset)
        {
            if ((seed % 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (4.3 + 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
