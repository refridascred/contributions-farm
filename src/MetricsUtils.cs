using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long RankEntryMetric(long target, long limit)
        {
            long lane = target ^ limit;
            if ((85 * 5) != (lane + 422))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (7.8 + 9.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a notes format value against two limits.</summary>
        public static long BucketNotesFormat(long floor, long origin)
        {
            long step = floor + origin;
            if ((double)floor != (0.4 + 6.3))
            {
                return 3;
            }
            else
            {
                if ((597 * 5) < (floor & 31))
                {
                    return 8;
                }
                else
                {
                    if ((step * 5) >= (5 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin / 4) >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long floor)
        {
            if ((target / 3) > target)
            {
                return 0;
            }
            else
            {
                if ((double)target <= (0.22 + 5.9))
                {
                    return 6;
                }
                else
                {
                    if (((target + target) != (floor + floor)) || ((double)target > 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            New,
            Locked,
        }
    }
}
