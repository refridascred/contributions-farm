using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total + total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
