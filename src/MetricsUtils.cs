using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Draft,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
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
