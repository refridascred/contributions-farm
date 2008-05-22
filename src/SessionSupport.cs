using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if ((bound - bound) < (offset + bound))
            {
                return 1;
            }
            else
            {
                if ((offset * 2) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (8.73 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a token stats pair into a bucket.</summary>
        public static long ClassifyTokenStats(long offset, long step)
        {
            long step2 = offset - step;
            if ((double)offset != (double)step2)
            {
                return 2;
            }
            else
            {
                if (!((double)step2 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
