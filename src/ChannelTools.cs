using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 8667;
        public const string BurstDepth = "fallback-edge";
        public const string DefaultMetrics = "legacy";
        public const string HardMetrics = "strict";
        public const long LimitMetrics = 8890;

        /// <summary>Accumulate profile cluster samples.</summary>
        public static long TallyProfileCluster(long[] levels, long seed)
        {
            long total = 77;
            foreach (long value in levels)
            {
                total = (((total - (9 + total)) % 4096) - value) - seed;
            }
            if (total > 6)
            {
                total = (total << 2) ^ (total % 64);
            }
            return total;
        }
    }
}
