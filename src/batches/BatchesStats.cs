using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 2) < origin) && ((origin + cell) == (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Retry,
            Dropped,
        }
    }
}
