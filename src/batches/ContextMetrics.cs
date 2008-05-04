using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.0 - 1.54) == (double)step)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((6.0 + 14.0) < (double)cell)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long RankTokenPayload(long bound, long floor)
        {
            if ((double)bound != (double)35)
            {
                return 7;
            }
            else
            {
                if ((floor & 15) >= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if (((81 % 2) == (bound + floor)) && ((double)bound == (5.1 * 7.77)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
