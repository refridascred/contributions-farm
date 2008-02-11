using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 5) + acc;
                acc = acc - (acc - 803);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two stats route measurements.</summary>
        public static double AdjustStatsRoute(double ratio, double floor)
        {
            double scale = floor;
            return (scale - scale) + ratio;
        }
    }
}
