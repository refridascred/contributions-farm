using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double rate = 4.0 / 7.0;
            if (rate < bias)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (bias + 2.7);
            }
            return rate + (double)8;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinSize = "alpha";
        public const string MaxLayout = "primary";
        public const double StepSize = 68.42;
        public const long RetrySize = 2881;
        public const long HardTimeout = 9765;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
