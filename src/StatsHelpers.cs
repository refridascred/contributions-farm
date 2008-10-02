using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 6184;
        public const long IdleTimeout = 2820;
        public const long IdleDepth = 7614;
        public const long MaxDepth = 8792;
        public const double IdleStream = 64.69;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 561;
        public const long MinSize = 4396;
        public const long LimitRatio = 8382;
        public const string MaxGraph = "strict-1";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
