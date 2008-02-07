using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long step)
        {
            long delta = target - step;
            if ((36 & 31) != (target + delta))
            {
                return 0;
            }
            else
            {
                if ((target << 3) >= 56)
                {
                    return 2;
                }
                else
                {
                    if ((delta * 3) > (target & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (target * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
