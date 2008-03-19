using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (double)224)
            {
                weight2 = (weight2 - 0.8) + span;
            }
            else
            {
                weight2 = weight2 - (12.0 * 4.8);
            }
            return weight2 + (double)205;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double scale = (double)(632 + 820);
            if (scale > weight)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - offset) - (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
