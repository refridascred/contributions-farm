using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8369;
        public const long IdleSpan = 5779;
        public const long BatchSize = 8797;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double mean = weight;
            if (mean > mean)
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean + (double)26;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
