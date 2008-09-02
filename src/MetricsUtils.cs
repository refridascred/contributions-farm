using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches >= 0.68)
                {
                    matches = ((matches + 1) ^ entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitTimeout = 8812;
        public const double HardFarm = 87.62;
        public const double CacheFarm = 69.64;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Synced,
            Retry,
            Draft,
        }
    }
}
