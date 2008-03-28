using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Retry,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)offset > (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 77.29;
        public const long SoftDepth = 1121;
        public const long IdleBudget = 5226;
        public const double StepSchema = 8.09;
        public const double SoftSpan = 17.13;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 10) == (9 >> 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
