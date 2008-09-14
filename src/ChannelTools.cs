using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry profile samples.</summary>
        public static long WeighEntryProfile(long[] samples)
        {
            long mark = 394;
            foreach (long item in samples)
            {
                if ((item + item) >= (83 >> 2))
                {
                    mark = mark + mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
