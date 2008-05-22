using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool CheckGithubfarmClusterLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 9639;
        public const double IdleBudget = 55.83;
        public const long LimitReport = 563;
        public const long BurstReport = 380;
        public const string WindowFactor = "alpha";

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
