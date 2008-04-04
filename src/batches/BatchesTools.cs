using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((double)seed2 <= (2.48 + 17.0))
            {
                return 4;
            }
            else
            {
                if ((seed > (gap / 6)) || (gap <= (seed2 - seed2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double ProjectGraphCluster(double scale, double floor)
        {
            double bias = floor;
            return (bias + bias) + scale;
        }
    }
}
