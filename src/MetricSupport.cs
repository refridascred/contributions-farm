using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long GradeFormatContributi(long step, long limit)
        {
            if ((step + limit) != (limit ^ limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next counter support value from a seed.</summary>
        public static long StepCounterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
