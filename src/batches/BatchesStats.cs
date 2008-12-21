using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long origin)
        {
            long cur = floor - origin;
            if (((double)cur != (8.0 * 0.7)) || ((double)cur == (8.53 - 8.1)))
            {
                return 4;
            }
            else
            {
                if (((double)origin > (8.2 - 4.74)) && (floor < (origin - cur)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Queued,
            Stale,
        }
    }
}
