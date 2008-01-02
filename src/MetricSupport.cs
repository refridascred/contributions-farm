using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long floor)
        {
            long anchor = 110;
            foreach (long cell in levels)
            {
                if ((cell & 255) > (floor % 24))
                {
                    anchor = (anchor << 2) ^ (9 / 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (3 + 751)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 2651;
        public const long IdleTimeout = 5907;
        public const long HardWidth = 9005;
        public const long RetryScore = 6388;
    }
}
