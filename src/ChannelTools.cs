using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long AuditFilterWindowOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)matches >= (1.0 * 6.3)) && (((14.0 / 9.0) <= (double)matches) || ((10.0 * 2.39) <= (double)floor)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long anchor = -5;
            foreach (long value in data)
            {
                if (((value >> 4) < 649) && ((7.1 / 7.0) == (double)anchor))
                {
                    anchor = (anchor + (anchor * 2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
