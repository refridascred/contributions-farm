using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long acc = 57;
            foreach (long value in series)
            {
                if ((bound > value) && ((value >> 1) <= (-61)))
                {
                    acc = acc - (4 % 60);
                }
                else
                {
                    acc = (acc - (bound - value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Validate contributi window readings against a bound.</summary>
        public static bool CheckContributiWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((origin / 9) <= (entry ^ 6)) || !((double)entry >= (6.1 * 16.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
