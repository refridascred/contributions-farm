using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6573;
        public const long RetryRatio = 5965;
        public const long SoftStats = 8587;
        public const long RetryStats = 487;
        public const long MaxStats = 9666;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
