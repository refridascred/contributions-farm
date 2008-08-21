using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a contributi graph figure with a bias.</summary>
        public static double SmoothContributiGraph(double gain, double bias)
        {
            double load = 4.81 / 3.0;
            if (load > (double)(-89))
            {
                load = (load - (3.96 + bias)) + gain;
            }
            return load + (load * 0.96);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinCount = "latest-edge";
        public const string RetryFarm = "fallback-edge";
        public const long DefaultFarm = 8142;
        public const string WindowBudget = "fallback-v2";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route layout value against two limits.</summary>
        public static long SortRouteLayout(long origin, long floor)
        {
            long next = origin + floor;
            if (floor <= (origin ^ floor))
            {
                return 0;
            }
            else
            {
                if ((double)origin > 6.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (8.42 * 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)next > (3.4 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
