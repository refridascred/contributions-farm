using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long mix = -399;
            foreach (long sample in series)
            {
                mix = (mix ^ (mix - sample)) + limit;
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ (mix >> 5)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 4767;
        public const long LimitInterval = 3295;
        public const string IdleSpan = "latest-v2";
        public const long WindowBudget = 6447;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
