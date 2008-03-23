using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double BlendGithubfarmMetrics(double rate, double bias)
        {
            double ratio = rate - 2.0;
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (1.4 / 7.0)) - bias;
            }
            else
            {
                ratio = ratio + (double)506;
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 6636;
        public const long CacheBudget = 3423;
        public const double StepBuffer = 4.25;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long seed)
        {
            if (seed > (408 & 127))
            {
                return 6;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 2;
                }
                else
                {
                    if ((target + 16) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
