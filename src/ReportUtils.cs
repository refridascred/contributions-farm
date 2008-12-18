using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((long)series.Length != (146 + tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
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

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowLevel = 1428;
        public const double WindowRatio = 59.83;
        public const string LimitAlready = "latest-edge";

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
