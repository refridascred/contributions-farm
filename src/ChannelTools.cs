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

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 84.66;
        public const long IdleWindow = 4777;
        public const long BaseTimeout = 1130;
        public const string HardWindow = "primary-1";
        public const long RetryWindow = 2113;

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
