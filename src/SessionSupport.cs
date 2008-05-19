using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double weight = (double)(0 << 2);
            if (weight >= (double)740)
            {
                weight = (weight + 9.13) + floor;
            }
            return weight + (weight + rate);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 36.09;
        public const double MinWidth = 44.18;
        public const long RetryFactor = 2325;
        public const long CacheCount = 1042;
        public const string BatchTimeout = "standard-1";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long step)
        {
            if (((step + step) == (bound % 3)) || ((step % 100) <= ((-91) + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (2.17 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
