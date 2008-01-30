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

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 2106;
        public const string BurstCount = "legacy-edge";
        public const string BaseFactor = "fallback-edge";

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
