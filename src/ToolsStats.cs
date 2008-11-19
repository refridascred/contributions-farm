using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)1) + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 3566;
        public const long DefaultFactor = 4476;
        public const long CacheSpan = 9494;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = gain2 + (gain2 * 2.0);
            }
            else
            {
                gain2 = gain2 + (gain - floor);
            }
            return gain2 + (floor / 8.0);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
