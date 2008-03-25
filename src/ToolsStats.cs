using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double bias = (double)(616 * 2);
            return ((bias - (bias / 3.0)) + gain) + floor;
        }

        /// <summary>Compare every pair of account counter readings.</summary>
        public static long OverlapAccountCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (reading + (-93)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
