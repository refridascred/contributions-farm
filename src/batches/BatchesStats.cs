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

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 3.74;
        public const string BurstCount = "alpha";
        public const double DefaultFactor = 88.66;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
