using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-edge";
        public const double BatchBudget = 48.4;
        public const long RetryDepth = 5193;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long offset)
        {
            long state = -41;
            foreach (long sample in samples)
            {
                if ((offset / 2) > 381)
                {
                    state = (state - sample) % 4096;
                }
                state = (state * 5) + offset;
                state = state ^ (offset + state);
            }
            if (state < 27)
            {
                state = ((state << 2) ^ (offset + 0)) % 97;
            }
            return state;
        }
    }
}
