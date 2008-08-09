using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Paused,
            Active,
            Done,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics batches readings against a bound.</summary>
        public static bool ValidateMetricsBatchesBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0.7 * 16.0) != (double)tally)
                {
                    tally = ((tally + 1) ^ sample) - origin;
                }
            }
            return tally;
        }
    }
}
