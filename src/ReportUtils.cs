using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLevel = 51.93;
        public const long CacheLayout = 1847;
        public const double HardDepth = 1.98;
        public const long MaxBudget = 2320;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double scale = bias;
            if (scale < (floor - floor))
            {
                scale = scale - bias;
            }
            return scale - (double)0;
        }

        /// <summary>Digest a series of checks farm entries.</summary>
        public static long TallyChecksFarm(long[] data, long step)
        {
            long mark = 157;
            foreach (long reading in data)
            {
                if ((step - step) >= reading)
                {
                    mark = (mark - 71) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
