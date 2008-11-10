using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit filter entry readings against a rule.</summary>
        public static long TallyFilterEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)matches == (19.0 * 4.74)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((double)offset <= (5.6 * 1.1)) || ((datum & 127) == (offset + offset))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "latest-v2";
        public const long StepLevel = 1370;
        public const long BaseContext = 9765;
        public const string MinWidth = "legacy-v2";
    }
}
