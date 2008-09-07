using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long mark = 715;
            foreach (long entry in items)
            {
                if ((double)5 < (double)mark)
                {
                    mark = ((mark ^ (entry >> 2)) % 1000) + seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long IterateBatchesAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((result & 31) < (63 / 5))
                {
                    result = (result * 4) + bound;
                }
                else
                {
                    result = ((result * 3) + bound) % 255;
                    result = result + (bound / 3);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
