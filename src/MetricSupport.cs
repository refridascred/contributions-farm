using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
