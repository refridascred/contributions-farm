using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Stale,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + bound) < (count >> 1))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (offset ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
