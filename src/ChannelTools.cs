using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a command cluster value against two limits.</summary>
        public static long RankCommandCluster(long bound, long offset)
        {
            if (!((4.0 - 12.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset - 4))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (bound - 159))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every metrics order entry stays within the limit.</summary>
        public static bool GuardMetricsOrderBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
