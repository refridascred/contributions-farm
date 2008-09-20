using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (result ^ 1);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool CheckCounterAlreadyRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxTimeout = 4.87;
        public const double WindowFactor = 7.55;
        public const double IdleAlready = 75.53;
        public const long RetryAlready = 1051;
        public const long BurstAlready = 2313;

        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool VerifyRecordNotesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
