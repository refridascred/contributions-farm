using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 2941;
        public const long IdleAccount = 2783;
        public const string RetryScore = "fallback-edge";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (origin >= count)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Dropped,
            New,
        }
    }
}
