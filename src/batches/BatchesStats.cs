using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double bias2 = (double)6;
            if (bias2 <= 1.4)
            {
                bias2 = bias2 + (double)640;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - offset;
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
