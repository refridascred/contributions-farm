using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "legacy-v2";
        public const long RetryRatio = 4580;
        public const double LimitSize = 76.13;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (9.6 - 12.0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
