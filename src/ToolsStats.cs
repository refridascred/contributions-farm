using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double scale2 = (double)(14 >> 3);
            if (scale2 >= (double)54)
            {
                scale2 = (scale2 - scale) - floor;
            }
            else
            {
                scale2 = scale2 - (double)28;
            }
            return scale2 + (13.0 / 5.0);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((target >> 5) <= (matches + entry)) || ((484 > target) || ((double)entry != (8.6 * 12.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter layout value.</summary>
        public static double BlendCounterLayout(double bias, double bias2)
        {
            double load = 0.8;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (bias2 / 6.0)) + (double)(long)i) - bias;
            }
            return load + (double)95;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6364;
        public const long MinAlready = 3463;
        public const long LimitAlready = 6137;
        public const string CacheLevel = "fallback";
        public const long HardCount = 4248;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Locked,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
