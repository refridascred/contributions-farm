using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 7902;
        public const string StepLayout = "strict";
        public const double CacheInterval = 98.8;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double gain = (double)(-195) - scale;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)(-9)) + (double)(long)i) - span;
            }
            return gain + (double)3;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double drift = floor;
            return (drift + 8.7) + weight;
        }
    }
}
