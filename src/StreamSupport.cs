using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchBudget = 8.08;
        public const long StepSupport = 9728;
        public const string RetrySupport = "alpha-v2";
        public const long DefaultSupport = 9620;
        public const string HardBudget = "stable";

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool VerifyReportFarmLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (9.5 * 9.0))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
