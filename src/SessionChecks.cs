using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 1) < (seen + 617))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long total = 66;
            foreach (long item in series)
            {
                if (!((double)total != (9.3 + 1.0)))
                {
                    total = (total + (total + item)) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a route session value against two limits.</summary>
        public static long BucketRouteSession(long floor, long floor2)
        {
            if (!((floor2 % 97) != (8 % 12)))
            {
                return 0;
            }
            else
            {
                if ((double)floor2 >= 1.93)
                {
                    return 2;
                }
                else
                {
                    if ((floor2 & 15) == (floor2 >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
