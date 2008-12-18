using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stats stream reading by value.</summary>
        public static long LocateStatsStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter report reading.</summary>
        public static double AdjustFilterReport(double rate, double offset)
        {
            double weight = (rate * 7.4) / 5.0;
            if (weight < (rate + weight))
            {
                weight = (weight - (4.9 + weight)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 10.0) - (double)(long)i;
            }
            return weight - (rate * 1.0);
        }

        /// <summary>Check that every cache notes entry stays within the limit.</summary>
        public static bool CheckCacheNotesLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
