using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double load = bias;
            if (load < (double)35)
            {
                load = (load - bias) - scale;
            }
            return load + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "standard";
        public const long WindowRoute = 7218;
        public const double BurstRoute = 91.11;
        public const long CacheFactor = 3337;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5973;
        public const string BaseEntry = "fallback-edge";
        public const long StepCount = 141;
        public const long LimitEntry = 2103;
    }
}
