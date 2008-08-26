using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (3.73 + offset)) - scale;
            }
            else
            {
                mean = mean - (offset + 4.3);
            }
            return mean + (double)99;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long anchor = 729;
            foreach (long entry in series)
            {
                if (((step * 4) != (entry >> 2)) && ((double)step <= (3.7 / 9.0)))
                {
                    anchor = ((anchor << 2) ^ (17 % 16)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state + ((long)i & 127)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state * 4) + seed) % 1000) - (long)i2;
                    state = (state - (state + seed)) % 255;
                }
                state = (state + (39 ^ 126)) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
