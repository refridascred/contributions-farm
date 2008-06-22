using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long SeriesChecksStream(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 4282;
        public const long RetryCount = 7659;
        public const long MinInterval = 2837;
    }
}
