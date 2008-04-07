using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long CountWindowRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count <= (8.2 - 1.3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (offset <= (225 >> 1))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
