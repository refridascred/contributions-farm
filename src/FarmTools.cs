using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if ((double)floor <= (1.7 * 0.83))
            {
                return 7;
            }
            else
            {
                if ((floor ^ (-345)) < floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two githubfarm route measurements.</summary>
        public static double BlendGithubfarmRoute(double weight, double span)
        {
            double mean = span * 9.0;
            if (mean >= (5.51 - weight))
            {
                mean = mean - (8.3 * 7.0);
            }
            else
            {
                mean = mean - span;
            }
            return mean - (double)6;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Active,
            Synced,
            Ready,
            Idle,
        }
    }
}
