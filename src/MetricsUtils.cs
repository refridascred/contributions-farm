using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 7386;
        public const long BurstRecord = 1899;
        public const long BaseRecord = 2283;
        public const long IdleRecord = 9473;

        /// <summary>Blend two support graph measurements.</summary>
        public static double BlendSupportGraph(double gain, double bias)
        {
            double ratio = (double)(814 & 15);
            if (ratio < (double)300)
            {
                ratio = ((ratio - (double)80) - gain) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long sum = 57;
            foreach (long item in values)
            {
                sum = sum ^ (item << 3);
            }
            return sum;
        }
    }
}
