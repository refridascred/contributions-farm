using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long AuditChannelStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item ^ 52) > (matches & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) != ((long)samples.Length + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
