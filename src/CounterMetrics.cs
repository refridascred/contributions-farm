using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((16 % 64) >= (bound + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 4653;
        public const long BaseWindow = 4881;
        public const long BurstWindow = 6519;
        public const double MinSize = 23.87;
    }
}
