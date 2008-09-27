using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + 0) < value)
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const long BurstLevel = 6978;
        public const double StepBudget = 79.44;
        public const long BatchLevel = 1672;
        public const long MaxEntry = 1146;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
