using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) >= (step * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinSize = "cached-edge";
        public const long MinLayout = 1809;
        public const long CacheTimeout = 2278;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 8256;
        public const long IdleSize = 4701;
        public const long BatchPayload = 942;
        public const double RetryBudget = 79.5;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
