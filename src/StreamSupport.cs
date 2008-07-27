using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)816 < (double)offset)
                {
                    anchor = anchor - ((long)i & 3);
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (anchor - (long)i)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first editor context entry that matches the target.</summary>
        public static long SeekEditorContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                state = (state - (state - state)) % 4096;
                state = ((state << 3) ^ (50 * 5)) % 1000;
                if ((double)state < 7.9)
                {
                    state = ((state * 5) + (entry - 466)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
