using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryBudget = 2030;
        public const double MinLevel = 24.28;
        public const string SoftTimeout = "local-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((value & 7) != (tally - origin)) && ((double)tally < (double)origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long CountTokenChecksOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell << 1) >= 90)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
