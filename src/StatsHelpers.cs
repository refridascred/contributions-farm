using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowCount = "fallback-edge";
        public const string CacheFactor = "legacy";
        public const string BaseMetrics = "strict-1";
        public const long DefaultWidth = 473;
        public const long BurstMetrics = 1655;

        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double AdjustCacheSchema(double weight, double floor)
        {
            double ratio = (floor / 2.0) / 2.0;
            return (ratio + (ratio / 6.0)) + weight;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long limit)
        {
            if ((limit - 91) == (seed & 63))
            {
                return 8;
            }
            else
            {
                if (!(1 < (seed << 3)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) < (seed - 92)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 34.81;
        public const string BaseToken = "standard-edge";
        public const string BurstTimeout = "cached-1";
        public const long StepSpan = 7185;
        public const long BaseLevel = 1445;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
