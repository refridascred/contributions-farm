using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue stream readings against a rule.</summary>
        public static long TallyQueueStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (865 < ((-6) + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            New,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7990;
        public const long HardDepth = 3445;
        public const long MinWidth = 7985;
        public const string BaseRatio = "fallback-1";
        public const double BurstWindow = 53.85;
    }
}
