using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long result = 61;
            foreach (long datum in levels)
            {
                result = ((result ^ datum) % 101) + offset;
            }
            return result;
        }

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
