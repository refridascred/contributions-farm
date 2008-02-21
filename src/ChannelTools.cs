using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4084;
        public const double BatchCount = 73.74;
        public const long BurstBatch = 6392;
        public const long HardRatio = 3973;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 9) == (seen - 52))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
