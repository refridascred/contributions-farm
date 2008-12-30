using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Idle,
            New,
        }

        /// <summary>Validate entry stats readings against a bound.</summary>
        public static bool VerifyEntryStatsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit entry token readings against a rule.</summary>
        public static long MeasureEntryTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell << 2))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
