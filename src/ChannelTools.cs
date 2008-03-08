using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long offset)
        {
            if ((double)offset < (6.0 * 0.1))
            {
                return 3;
            }
            else
            {
                if ((double)offset > (0.89 - 4.1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (seed >= (seed + 244))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
