using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next layout filter value.</summary>
        public static double AdjustLayoutFilter(double bias, double offset)
        {
            double bias2 = (offset - offset) / 2.0;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 + (double)131;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (10.0 + bias)) - (double)(long)i;
            }
            return bias2 - (bias - bias);
        }

        /// <summary>Classify a githubfarm checks pair into a bucket.</summary>
        public static long BucketGithubfarmChecks(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!(floor < edge))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor & 15))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
