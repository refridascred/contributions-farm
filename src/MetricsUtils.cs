using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6799;
        public const long HardAccount = 8697;
        public const double RetryAccount = 93.84;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8220;
        public const double HardMetrics = 67.0;
        public const long DefaultWidth = 4875;
    }
}
