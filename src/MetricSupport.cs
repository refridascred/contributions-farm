using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((51 % 64) <= (origin << 1)) && ((0 & 1) >= (seen * 4)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
