using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheBudget = 4646;
        public const long SoftEditor = 9279;
        public const long CacheInterval = 3170;
        public const string HardCount = "latest-1";

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - bias))
            {
                bias = bias + (floor * 3.0);
            }
            return bias + (gain + bias);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                anchor = (anchor * 2) + 596;
                if ((double)(-1) == (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
