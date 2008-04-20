using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "primary-edge";
        public const double BaseTimeout = 74.42;
        public const string BurstCount = "local-1";
        public const double LimitCount = 24.0;
        public const string IdleTimeout = "cached-v2";

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
