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

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 - scale) + bias;
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
