using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Idle,
            Draft,
            Pending,
            New,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report cluster entries that pass the check.</summary>
        public static long MeasureReportClusterOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((5 / 7) >= (entry + 755))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order contributi figure with a bias.</summary>
        public static double ProjectOrderContributi(double gain, double floor)
        {
            double ratio = floor + (12.0 + gain);
            if (ratio <= gain)
            {
                ratio = ratio + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - (ratio - gain);
        }
    }
}
