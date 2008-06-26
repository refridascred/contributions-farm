using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 8858;
        public const long BatchFarm = 6671;
        public const double RetryFarm = 36.65;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Synced,
            Ready,
            Queued,
            Retry,
        }
    }
}
