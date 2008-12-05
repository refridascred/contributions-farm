using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2242;
        public const long WindowInterval = 9057;
        public const long MaxFactor = 5206;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long state = -3;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ 67;
                state = (state + (state + state)) % 97;
                if ((state / 9) >= cell)
                {
                    state = (state * 4) + 7;
                }
            }
            if (state > 0)
            {
                state = state - (state << 2);
            }
            return state;
        }
    }
}
