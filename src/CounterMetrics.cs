using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LocateReportCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long total = 18;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell << 2)) % 255;
                if (((double)total <= 1.46) || ((7.0 * 2.1) > (double)total))
                {
                    total = total - 14;
                }
                else
                {
                    total = (total * 3) + (cell << 3);
                }
            }
            if (total < 0)
            {
                total = (total - (total % 24)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((11.0 - 3.39) <= (double)reading))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
