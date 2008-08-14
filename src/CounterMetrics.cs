using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxFactor = 43.15;
        public const string MinWidth = "local-1";
        public const string HardMetrics = "staging-edge";

        /// <summary>Grade a editor counter value against two limits.</summary>
        public static long RankEditorCounter(long seed, long step)
        {
            long diff = seed ^ step;
            if (diff <= (diff * 4))
            {
                return 8;
            }
            else
            {
                if (((5.0 * 4.19) == (double)diff) || ((step & 63) != (step * 2)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
