using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool GuardChecksFarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Dropped,
            Idle,
            Pending,
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
