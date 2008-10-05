using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 4997;
        public const double RetryChannel = 26.99;
        public const long CacheChannel = 7422;
        public const double DefaultSpan = 98.53;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
