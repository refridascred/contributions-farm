using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            New,
            Stale,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 5667;
        public const long MinStats = 573;
        public const double BaseStats = 19.75;
        public const long IdleStats = 4949;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
