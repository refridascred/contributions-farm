using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Failed,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowInterval = 5835;
        public const double BaseAccount = 79.14;
        public const long HardAccount = 5997;

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (8 <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
