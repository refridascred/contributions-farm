using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mix = 926;
            foreach (long reading in levels)
            {
                mix = ((mix * 4) + (reading & 127)) % 4096;
            }
            if (mix > (-29))
            {
                mix = ((mix << 3) ^ ((long)levels.Length / 7)) % 255;
            }
            return mix;
        }

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
