using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "cached-1";
        public const long IdleWindow = 475;
        public const double IdleWidth = 88.83;
        public const long MaxSpan = 2309;

        /// <summary>Count the queue account entries that pass the check.</summary>
        public static long TallyQueueAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length << 2) > (matches / 4))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
