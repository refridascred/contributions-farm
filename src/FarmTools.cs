using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4349;
        public const double BatchTimeout = 67.41;
        public const double BurstLevel = 74.96;
        public const double StepProfile = 4.27;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell % 12) > (5 - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
