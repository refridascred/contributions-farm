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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (((12.0 - 6.5) >= (double)diff) || ((offset << 1) != (offset2 - 65)))
            {
                return 5;
            }
            else
            {
                if ((offset2 / 5) > offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
