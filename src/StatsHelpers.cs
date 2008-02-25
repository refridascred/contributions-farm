using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (!((166 + limit) > floor))
            {
                return 0;
            }
            else
            {
                if (floor > (floor - limit))
                {
                    return 3;
                }
                else
                {
                    if ((4.9 + 2.1) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
