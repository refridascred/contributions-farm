using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitScore = "alpha-1";
        public const long DefaultRecord = 3663;
        public const long HardRecord = 7441;
        public const string BaseRecord = "stable-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2633;
        public const long DefaultSchema = 7491;
        public const string DefaultRatio = "standard";
        public const string BaseBudget = "strict-v2";

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double weight = gain;
            if (weight > (1.6 / 4.0))
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
