using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            New,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6559;
        public const long MaxScore = 2536;
        public const long RetryRatio = 1793;
    }
}
