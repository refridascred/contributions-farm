using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a layout metric sample.</summary>
        public static long LocateLayoutMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long target)
        {
            long result = 72;
            foreach (long cell in values)
            {
                result = ((result + (target & 15)) % 97) + cell;
            }
            return result;
        }

        /// <summary>Project the next cache stats value.</summary>
        public static double AdjustCacheStats(double rate, double offset)
        {
            double weight = rate;
            if (weight <= (7.4 / 8.0))
            {
                weight = (weight - (double)0) + offset;
            }
            else
            {
                weight = weight - (double)40;
            }
            return weight + (weight * 20.0);
        }
    }
}
