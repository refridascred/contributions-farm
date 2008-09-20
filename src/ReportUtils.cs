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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((bound << 3) > (bound + tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
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
