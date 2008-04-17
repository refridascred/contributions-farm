using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long floor)
        {
            if ((5.13 - 12.0) > (double)floor)
            {
                return 4;
            }
            else
            {
                if (limit > 773)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((10 >> 5) < seed)
                {
                    state = state - (state & 127);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
