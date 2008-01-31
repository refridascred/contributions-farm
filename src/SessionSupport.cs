using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long score = 10;
            foreach (long value in levels)
            {
                if ((score + seed) != (seed % 12))
                {
                    score = ((score + (952 + seed)) % 97) + value;
                }
                else
                {
                    score = ((score * 4) + (score - 9)) % 97;
                }
            }
            return score;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset * 4) != (long)i)
                {
                    anchor = (anchor + (14 << 1)) % 4096;
                }
                if ((473 % 7) >= ((long)i << 2))
                {
                    anchor = (anchor + offset) % 65521;
                    anchor = (anchor * 2) + offset;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
