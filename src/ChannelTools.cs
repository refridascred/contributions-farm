using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor << 2) >= 13)
                {
                    total = (total ^ (total % 100)) % 101;
                }
                total = (total << 3) ^ (total + total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a command metrics sample.</summary>
        public static long LocateCommandMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
