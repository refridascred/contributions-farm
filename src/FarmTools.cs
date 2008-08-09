using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 603;
        public const string HardBudget = "open-1";
        public const double LimitScore = 64.61;
        public const long SoftLevel = 541;
        public const double IdleEntry = 94.14;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry <= (tally >> 2))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "primary-v2";
        public const long SoftSize = 6446;
        public const long IdleBudget = 9280;
    }
}
