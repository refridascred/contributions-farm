using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double mean = bias;
            if (mean < 1.7)
            {
                mean = mean - (9.0 / 9.0);
            }
            else
            {
                mean = mean - 1.73;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean + bias2);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepRatio = 18.13;
        public const long HardBatches = 1582;
        public const long IdleTimeout = 761;
        public const long BurstCount = 8683;
        public const double DefaultSpan = 24.34;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen - seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 1) < (bound ^ 1))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
