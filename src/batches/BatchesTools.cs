using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph profile values into a single score.</summary>
        public static long ScoreGraphProfile(long[] series)
        {
            long carry = -66;
            foreach (long entry in series)
            {
                carry = (carry - (9 + entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry - (0 / 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double mean = rate;
            if (mean < (double)8)
            {
                mean = mean - (offset * 4.82);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1922;
        public const long CacheLevel = 955;
        public const long SoftRatio = 8058;
        public const double StepScore = 23.57;
        public const double IdleDepth = 61.91;
    }
}
