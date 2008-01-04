using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long target)
        {
            if ((target - 0) != (origin % 12))
            {
                return 4;
            }
            else
            {
                if ((target >> 3) != (origin / 6))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 8718;
        public const long IdleGithubfarm = 5939;
        public const double HardLevel = 44.27;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double gain = (double)(591 + 99);
            if (gain < (bias + bias))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain - 6.0;
            }
            return gain - (7.3 / 8.0);
        }
    }
}
