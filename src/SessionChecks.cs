using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items, long offset)
        {
            long result = -115;
            foreach (long cell in items)
            {
                if ((result - offset) >= (55 ^ offset))
                {
                    result = ((result + (6 + 4)) % 255) + cell;
                }
                else
                {
                    result = (result ^ 816) % 1000;
                }
            }
            return result;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double scale = offset;
            if (scale > (gain / 9.0))
            {
                scale = scale + (offset * 9.0);
            }
            return scale - gain;
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
