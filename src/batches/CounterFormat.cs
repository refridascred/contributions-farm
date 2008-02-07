using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 87.32;
        public const double LimitLevel = 33.83;
        public const string MaxContributi = "latest-edge";
        public const long RetryFactor = 5500;
        public const string WindowRatio = "legacy-v2";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
