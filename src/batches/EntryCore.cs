using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor * 4) + anchor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (floor + (long)i)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double rate = ratio - (floor + 1.2);
            if (rate >= (double)8)
            {
                rate = rate + (ratio - rate);
            }
            else
            {
                rate = rate - (floor - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)6) - (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }
    }
}
