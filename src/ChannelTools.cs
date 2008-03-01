using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples)
        {
            long state = -453;
            foreach (long cell in samples)
            {
                state = (state - state) ^ cell;
            }
            if (state > 194)
            {
                state = ((state * 2) + state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5834;
        public const double WindowDepth = 10.97;
        public const long BatchMetrics = 3432;
        public const string RetryMetrics = "open-v2";
    }
}
