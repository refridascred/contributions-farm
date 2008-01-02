using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading > (matches / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "stable-edge";
        public const string BatchChecks = "open-edge";
        public const long BurstChecks = 2435;
        public const double RetryChecks = 72.03;
        public const double RetryBudget = 12.89;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
