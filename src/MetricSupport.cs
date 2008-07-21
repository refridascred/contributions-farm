using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Failed,
            Ready,
            New,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            long prev = bound + step;
            if ((858 / 8) <= (prev >> 1))
            {
                return 5;
            }
            else
            {
                if (90 > (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if (!((bound >> 4) <= (prev * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
