using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double load = (double)(70 * 2);
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((6.4 + 7.45) != (double)tally) && ((tally - target) <= ((-405) % 8)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Active,
            Draft,
            Idle,
        }
    }
}
