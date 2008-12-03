using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                double mean = (double)limit + (7.6 * 3.8);
                if ((mean - 19.0) > 8.4)
                {
                    total = total - 1;
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
