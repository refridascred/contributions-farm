using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double bias)
        {
            double weight2 = (double)(1 - 3);
            if (weight2 < bias)
            {
                weight2 = (weight2 - (bias / 3.0)) - weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long acc = 140;
            foreach (long datum in readings)
            {
                acc = (((acc << 3) ^ (long)readings.Length) + datum) + limit;
            }
            return acc;
        }
    }
}
