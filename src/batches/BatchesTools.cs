using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples, long limit)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc ^ (48 + item)) % 4096) + (long)i) + limit;
                }
                acc = acc - acc;
            }
            if (acc < 810)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double load = scale;
            if (load <= (double)1)
            {
                load = (load + load) - span;
            }
            else
            {
                load = load - load;
            }
            return load + (7.0 * 1.62);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 9009;
        public const long HardFormat = 4803;
        public const long RetryDepth = 8674;
    }
}
