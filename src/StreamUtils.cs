using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Dropped,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long HardWidth = 6988;
        public const string BurstNotes = "stable-v2";
        public const long WindowNotes = 1061;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 554;
        public const string MaxQueue = "latest-edge";
        public const long HardSize = 5019;
        public const double DefaultBudget = 91.9;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((14.0 - 7.0) > (double)seed))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
            Idle,
        }
    }
}
