using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 49.81;
        public const double DefaultFactor = 78.13;
        public const string LimitDepth = "stable-v2";
        public const long WindowDepth = 404;
        public const string SoftFactor = "legacy-edge";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long seed)
        {
            long anchor = 77;
            foreach (long value in series)
            {
                if ((value > (anchor * 4)) || ((11.0 - 0.94) == (double)value))
                {
                    anchor = (anchor ^ anchor) - seed;
                }
            }
            return anchor % 4096;
        }
    }
}
