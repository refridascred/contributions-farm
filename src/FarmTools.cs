using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels, long offset)
        {
            long state = 44;
            foreach (long item in levels)
            {
                if (state < item)
                {
                    state = (((state << 2) ^ (item + (-796))) % 101) + offset;
                }
                else
                {
                    state = (state ^ (64 ^ item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
