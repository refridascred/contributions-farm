using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Locate a profile counter reading by value.</summary>
        public static long LocateProfileCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long target, long step)
        {
            long slot = target + step;
            if ((double)slot != (13.0 * 4.0))
            {
                return 3;
            }
            else
            {
                if ((target + step) <= slot)
                {
                    return 0;
                }
                else
                {
                    if (((3.8 / 3.0) <= (double)target) || ((target + step) <= (target % 100)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 2590;
        public const long SoftInterval = 6306;
        public const long CacheMetrics = 5597;
        public const double IdleMetrics = 8.66;
    }
}
