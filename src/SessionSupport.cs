using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long origin)
        {
            if (((double)target >= (11.0 * 7.0)) || ((target + origin) < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if (origin < (target % 100))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Active,
            Failed,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double weight = (double)(900 >> 2);
            return ((weight - weight) + gain) + bias;
        }
    }
}
