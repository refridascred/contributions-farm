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

        /// <summary>Compare every pair of support contributi readings.</summary>
        public static long OverlapSupportContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
