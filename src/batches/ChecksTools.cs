using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count == (3.9 / 7.0))
                {
                    count = ((count + 1) + value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3861;
        public const long SoftRatio = 4153;
        public const long SoftSpan = 7644;
        public const long MinTimeout = 6316;
        public const long RetryChecks = 5793;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Dropped,
            Failed,
            Done,
            New,
        }
    }
}
