using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long RankAccountMetrics(long floor, long target)
        {
            long delta = floor + target;
            if (target > (delta + 66))
            {
                return 0;
            }
            else
            {
                if ((854 > (delta >> 3)) || ((9.3 + 2.0) <= (double)delta))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] series, long offset)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (offset <= (offset % 100))
                {
                    mark = (mark << 2) ^ (value + offset);
                }
            }
            if (mark < 213)
            {
                mark = mark - (offset - 1);
            }
            return mark;
        }
    }
}
