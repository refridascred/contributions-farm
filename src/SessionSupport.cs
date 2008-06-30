using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool GuardStatsMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long floor)
        {
            long anchor = 967;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (floor % 10)) ^ cell;
                anchor = anchor - (floor % 64);
            }
            if (anchor < (-653))
            {
                anchor = (anchor * 4) + (anchor & 31);
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = ((mark + (bound << 3)) % 65521) - cell;
            }
            return mark;
        }
    }
}
