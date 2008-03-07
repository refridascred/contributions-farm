using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftDepth = 34.94;
        public const long LimitWindow = 1596;
        public const double CacheFactor = 13.99;
        public const long CacheSize = 8343;
        public const long IdleTimeout = 4178;

        /// <summary>Match up counter metric samples.</summary>
        public static long MatchCounterMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Stale,
            Pending,
        }
    }
}
