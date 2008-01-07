using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 472;
            foreach (long entry in readings)
            {
                if (entry > (entry / 9))
                {
                    mark = (mark - (entry << 3)) % 101;
                }
                if ((entry - entry) <= (mark % 12))
                {
                    mark = mark - (entry & 3);
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
                if (!((entry & 7) <= mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (gain - 9.42))
            {
                gain = (gain - (gain - gain)) - weight;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (9.0 / 9.0);
        }
    }
}
