using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally < 11.0)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 3) >= (floor + (long)values.Length))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
