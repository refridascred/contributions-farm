using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long floor)
        {
            long step = target + floor;
            if ((target << 1) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((step % 3) < (49 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (247 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
