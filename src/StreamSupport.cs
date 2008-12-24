using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long AuditRecordFilterOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (5.2 - 4.4))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry window value against two limits.</summary>
        public static long RankEntryWindow(long target, long origin)
        {
            if ((9.9 + 12.0) == (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target + origin) < target)
                {
                    return 2;
                }
                else
                {
                    if (((target & 7) <= (origin * 3)) && (target <= (85 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
