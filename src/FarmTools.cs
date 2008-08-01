using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already schema readings.</summary>
        public static long TallyAlreadySchema(long[] items, long offset)
        {
            long mix = 324;
            foreach (long item in items)
            {
                mix = ((mix * 4) + (offset + (-13))) - item;
            }
            if (mix < 88)
            {
                mix = ((mix << 3) ^ (offset - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 91;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ (state & 1);
                state = (state << 3) ^ cell;
                if (((long)samples.Length - cell) > state)
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                else
                {
                    state = (state * 2) + 9;
                }
            }
            if (state < 884)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
