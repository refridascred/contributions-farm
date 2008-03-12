using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryWidth = 89.3;
        public const double DefaultTimeout = 41.91;
        public const double MinRatio = 39.04;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            long edge = origin + floor;
            if (((edge + origin) != (origin >> 2)) || ((0 >> 4) <= edge))
            {
                return 6;
            }
            else
            {
                if (((floor + edge) > (edge * 4)) || ((origin % 7) <= (edge << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ edge) == (floor - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
