using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double ratio = (double)(71 - 514);
            if (ratio <= 0.54)
            {
                ratio = (ratio - (bias / 2.0)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (double)198;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Failed,
        }
    }
}
