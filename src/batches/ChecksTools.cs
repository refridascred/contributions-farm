using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token entry value from a seed.</summary>
        public static long DeriveTokenEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long AuditRecordCounterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - item) == (floor - 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxSpan = "primary-v2";
        public const long LimitStats = 3846;
        public const long BaseStats = 4760;
        public const long SoftStats = 2994;
        public const double RetryStats = 75.06;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
