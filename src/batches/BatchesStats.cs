using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = (((mark + (831 >> 3)) % 1000) + entry) + step;
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total << 3) ^ (total & 127)) % 255;
                    total = ((total * 4) + (total - (long)i2)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double bias)
        {
            double mean = (double)(547 << 3);
            if (mean <= (bias / 2.0))
            {
                mean = (mean - 3.98) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (bias + bias);
        }
    }
}
