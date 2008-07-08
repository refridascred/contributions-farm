using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Closed,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((87 & 7) != (step << 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
