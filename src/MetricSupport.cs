using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleFactor = 6261;
        public const double LimitQueue = 39.98;
        public const long BaseFactor = 3172;
        public const long BurstCount = 9775;
        public const string BatchWidth = "staging-1";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
