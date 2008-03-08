using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Active,
            New,
            Synced,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 31) > (entry << 2)) || !((60 + entry) <= 71))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
