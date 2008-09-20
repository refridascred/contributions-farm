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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series, long target)
        {
            long result = 3;
            foreach (long reading in series)
            {
                if ((reading - target) < reading)
                {
                    result = (result ^ target) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (reading + target);
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxTimeout = 4.87;
        public const double WindowFactor = 7.55;
        public const double IdleAlready = 75.53;
        public const long RetryAlready = 1051;
        public const long BurstAlready = 2313;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Synced,
            Closed,
            Idle,
        }

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
