using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data)
        {
            long sum = 76;
            foreach (long reading in data)
            {
                sum = (sum << 2) ^ (92 ^ reading);
            }
            if (sum < 96)
            {
                sum = (sum + (sum - sum)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 6972;
        public const long HardLevel = 7403;
        public const string HardRecord = "staging-v2";
        public const long MinRecord = 4634;
        public const long MaxRecord = 1957;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Closed,
            Pending,
        }
    }
}
