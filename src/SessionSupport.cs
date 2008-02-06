using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstLevel = 44.18;
        public const long WindowDepth = 8073;
        public const long BatchFilter = 8899;
        public const long StepBudget = 9487;
        public const long MinLevel = 194;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
