using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool GuardSupportGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!!(tally <= (38 + offset)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const double BaseBudget = 10.3;
        public const double SoftSpan = 50.19;
    }
}
