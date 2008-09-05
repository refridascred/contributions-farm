using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] values)
        {
            long sum = 17;
            foreach (long value in values)
            {
                if ((sum << 3) >= sum)
                {
                    sum = ((sum * 5) + (sum + value)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheWidth = 83.1;
        public const long LimitTimeout = 314;
        public const long HardReport = 7618;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
