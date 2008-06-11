using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > 16.0)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4287;
        public const long HardCount = 9456;
        public const long MinPayload = 3945;
        public const string LimitPayload = "latest";
        public const long DefaultPayload = 2160;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 7136;
        public const string WindowFactor = "latest-v2";
        public const long LimitSpan = 7434;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
