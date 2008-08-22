using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset - matches) >= (matches - offset))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout profile value against two limits.</summary>
        public static long ClassifyLayoutProfile(long origin, long target)
        {
            long cur = origin - target;
            if ((cur + cur) <= cur)
            {
                return 8;
            }
            else
            {
                if ((197 - cur) != (314 / 8))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (cur / 4)) || ((origin - origin) != (origin >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer report entry that matches the target.</summary>
        public static long SeekBufferReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
