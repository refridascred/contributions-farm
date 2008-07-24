using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate context already samples.</summary>
        public static long CombineContextAlready(long[] samples)
        {
            long state = 184;
            foreach (long entry in samples)
            {
                if (entry <= state)
                {
                    state = (state - (state + 966)) % 97;
                }
                else
                {
                    state = (state + (entry & 3)) % 65521;
                }
                if ((state - entry) < state)
                {
                    state = ((state * 2) + (state ^ entry)) % 97;
                }
                else
                {
                    state = ((state * 4) + (state + entry)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSpan = 5070;
        public const double DefaultStream = 53.42;
        public const long MinStream = 4555;
        public const long SoftScore = 2197;
    }
}
