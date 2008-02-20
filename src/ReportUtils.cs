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

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 1.96;
        public const long SoftBatch = 1064;
        public const double CacheRatio = 23.93;
        public const long RetrySize = 4423;

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

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
