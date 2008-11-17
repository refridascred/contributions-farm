using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length > cell) || ((matches + cell) >= (matches * 3))) || !((double)matches >= (2.8 + 6.43)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }
    }
}
