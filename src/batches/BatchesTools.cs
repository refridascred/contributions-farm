using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double drift = (double)(34 & 255);
            if (drift <= (drift - span))
            {
                drift = (drift + (double)653) + ratio;
            }
            else
            {
                drift = drift - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 4198;
        public const string BatchCluster = "cached";
        public const long WindowScore = 1284;
        public const long WindowCluster = 7272;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
