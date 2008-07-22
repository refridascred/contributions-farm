using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long floor)
        {
            long state = 384;
            foreach (long value in samples)
            {
                if ((value & 1) < (floor + floor))
                {
                    state = (state + (value / 4)) % 97;
                    state = (state + (state - state)) % 255;
                }
                if ((value + floor) > floor)
                {
                    state = (state << 2) ^ floor;
                }
                else
                {
                    state = (state ^ value) % 97;
                }
            }
            if (state < 664)
            {
                state = state - (state << 3);
            }
            return state;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                if (8.29 > (double)result)
                {
                    result = result ^ (result << 3);
                }
                else
                {
                    result = ((result << 2) ^ (57 + reading)) % 97;
                }
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long bound)
        {
            if ((10.0 * 17.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((664 >> 1) < (bound + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
