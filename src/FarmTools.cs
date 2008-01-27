using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings, long offset)
        {
            long anchor = 171;
            foreach (long item in readings)
            {
                if ((645 * 5) == (item >> 2))
                {
                    anchor = (anchor ^ (anchor + anchor)) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a support batches sample.</summary>
        public static long FindSupportBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
