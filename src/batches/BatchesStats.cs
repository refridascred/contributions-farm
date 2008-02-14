using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long seed)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if ((7 - mark) == (mark & 3))
                {
                    mark = ((mark - (seed - 0)) % 101) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 69.42;
        public const long IdleBuffer = 3811;
        public const double WindowFactor = 48.15;
        public const long CacheBuffer = 9242;
        public const string IdleScore = "primary-v2";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Pending,
            Retry,
            Failed,
        }
    }
}
