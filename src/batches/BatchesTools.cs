using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6976;
        public const string SoftSupport = "local-1";
        public const long DefaultScore = 5385;

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
