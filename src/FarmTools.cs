using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data, long origin)
        {
            long state = 41;
            foreach (long entry in data)
            {
                state = state + (state % 12);
                if (!((state << 2) < origin))
                {
                    state = state ^ entry;
                }
                else
                {
                    state = (state + (origin + state)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long StepOrderContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ (201 & 7);
                if (!((bound * 5) > bound))
                {
                    result = result ^ ((long)i * 4);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
