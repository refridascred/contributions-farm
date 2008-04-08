using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 6339;
        public const string BurstMetrics = "local";
        public const long LimitMetrics = 1780;

        /// <summary>Classify a batch buffer pair into a bucket.</summary>
        public static long GradeBatchBuffer(long target, long target2)
        {
            if ((4.0 * 10.0) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if ((double)target2 < 3.5)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
