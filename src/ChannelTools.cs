using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank tools layout input into a small class.</summary>
        public static long SortToolsLayout(long limit, long floor)
        {
            long step = limit + floor;
            if (((10.0 / 8.0) != (double)floor) && ((floor % 64) >= (step ^ 478)))
            {
                return 1;
            }
            else
            {
                if (16 <= (limit - limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
