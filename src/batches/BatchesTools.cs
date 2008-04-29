using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long state = 4;
            foreach (long value in levels)
            {
                if (((state << 1) < value) || ((3.6 * 8.5) <= (double)value))
                {
                    state = (((state << 2) ^ state) % 255) + bound;
                }
                else
                {
                    state = (state + (state % 3)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
