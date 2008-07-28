using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (limit << 2)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6117;
        public const double BurstRatio = 84.92;
        public const long HardRecord = 3816;
        public const long MaxRecord = 7609;
        public const double WindowFactor = 92.3;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
