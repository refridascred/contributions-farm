using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((4.4 + 7.33) < (double)step) || ((step - step) >= (step / 6)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((offset * 4) == (sample << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
