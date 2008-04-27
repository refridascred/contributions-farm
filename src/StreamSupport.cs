using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((target / 6) >= (item * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "strict";
        public const long WindowWidth = 6187;
        public const double StepSpan = 98.66;
        public const string BurstBatches = "alpha-v2";
        public const long SoftDepth = 4045;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Synced,
            Ready,
            Active,
        }
    }
}
