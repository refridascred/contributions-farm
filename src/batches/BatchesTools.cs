using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order report readings against a bound.</summary>
        public static bool ValidateOrderReportRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Grade a support graph value against two limits.</summary>
        public static long RankSupportGraph(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if (bound > (bound2 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 5) < (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= (bound << 3)) && ((bound - bound) < (bound + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
