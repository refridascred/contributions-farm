using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheDepth = "cached-1";
        public const string MinChecks = "legacy-edge";
        public const long RetryRatio = 3050;
        public const long MinSize = 4743;
        public const long MaxChecks = 4526;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
