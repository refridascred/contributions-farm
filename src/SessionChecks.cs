using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3991;
        public const double MinSize = 93.58;
        public const long StepBudget = 4772;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item << 1) != (tally - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
