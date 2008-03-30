using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8440;
        public const double StepFactor = 55.18;
        public const string HardFactor = "alpha-1";
        public const string BaseCount = "primary-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (906 & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long CountNotesCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.26 / 5.0) > (double)count)
                {
                    count = ((count + 1) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + (offset - 14);
                long edge = mark;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (edge >> 2)) % 255) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many profile cluster samples are out of range.</summary>
        public static long MeasureProfileClusterMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= (bound - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Dropped,
            Draft,
        }
    }
}
