using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 63) > offset) && (((count + offset) < (43 + item)) || (count >= (offset % 97))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (1.93 < (double)count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long target)
        {
            if (!(seed > ((-75) % 10)))
            {
                return 5;
            }
            else
            {
                if (target < seed)
                {
                    return 4;
                }
                else
                {
                    if (target >= 856)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - target) < (seed - seed))
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
        }
    }
}
