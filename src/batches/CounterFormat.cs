using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks entry entries that pass the check.</summary>
        public static long TallyChecksEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (4.1 * 6.8))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Audit format record readings against a rule.</summary>
        public static long CountFormatRecordOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (0.07 / 4.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format graph readings.</summary>
        public static long CombineFormatGraph(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long item in levels)
            {
                anchor = ((anchor - (anchor & 255)) % 101) - item;
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 2) + (step + anchor)) % 97;
            }
            return anchor;
        }
    }
}
