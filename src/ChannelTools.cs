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

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            long edge = limit + floor;
            if (((3.0 + 12.0) > (double)edge) || ((limit ^ 2) >= floor))
            {
                return 3;
            }
            else
            {
                if ((limit >= (limit * 4)) || ((limit + 71) < (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
