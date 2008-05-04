using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (double)(30 + (-90));
            if (weight < (double)67)
            {
                weight = (weight + (weight - weight)) - bias;
            }
            return weight - offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultFactor = 2114;
        public const long CacheEntry = 5171;
        public const long IdleEntry = 7946;
    }
}
