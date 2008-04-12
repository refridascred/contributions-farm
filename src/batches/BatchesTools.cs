using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 976;
        public const string StepFarm = "open-v2";
        public const string IdleSpan = "local";
        public const long IdleFarm = 1666;
        public const long IdleDepth = 3390;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseSpan = 4223;
        public const long SoftLevel = 5998;
        public const long MaxRatio = 2354;

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double mean = bias + scale;
            if (mean > scale)
            {
                mean = mean - (double)2;
            }
            return mean + mean;
        }
    }
}
