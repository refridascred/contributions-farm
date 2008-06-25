using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinTimeout = 1360;
        public const long HardFarm = 7049;
        public const long LimitCount = 1462;
        public const string MaxFarm = "alpha-edge";
        public const long MinFarm = 9995;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long sum = 1;
            foreach (long value in items)
            {
                if (!((double)value == (9.03 * 14.0)))
                {
                    sum = sum - (sum - sum);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + (4 - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 8198;
        public const long CacheWidth = 5956;
        public const string IdleQueue = "local";

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "standard-v2";
        public const string BurstRatio = "local-edge";
        public const long RetryLevel = 8930;
    }
}
