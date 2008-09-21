using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool GuardStatsContributiBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + (mark - mark);
                mark = (mark ^ origin) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7395;
        public const long IdleMetric = 8657;
        public const double MinDepth = 84.52;
        public const string IdleFactor = "local";

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            long prev = origin + target;
            if (((double)origin <= (9.74 / 8.0)) && ((340 * 4) <= (origin ^ origin)))
            {
                return 4;
            }
            else
            {
                if (!((prev & 255) != (prev % 7)))
                {
                    return 5;
                }
                else
                {
                    if ((target % 16) >= (target / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + 80) <= (origin << 3)) && ((double)prev < (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
