using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstCount = 17.47;
        public const long IdleCount = 9211;
        public const long BatchSize = 8806;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8447;
        public const double HardRecord = 22.25;
        public const double RetryRecord = 68.38;
        public const double HardSize = 18.02;

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 24.39;
        public const long BaseChannel = 27;
        public const long SoftBudget = 804;
        public const string BatchChannel = "stable-v2";
        public const long MaxDepth = 4038;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
