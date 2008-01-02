using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 3637;
        public const long MinFilter = 1575;
        public const string BurstFilter = "standard-edge";
        public const long DefaultSpan = 7767;

        /// <summary>Project the next profile route value.</summary>
        public static double AdjustProfileRoute(double gain, double bias)
        {
            double weight = gain;
            if (weight <= bias)
            {
                weight = weight - (bias / 2.0);
            }
            return weight + bias;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Failed,
            Dropped,
        }
    }
}
