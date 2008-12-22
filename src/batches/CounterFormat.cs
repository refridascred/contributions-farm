using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-edge";
        public const long DefaultBatch = 9994;
        public const long LimitSpan = 3753;
        public const string MaxBatch = "alpha-1";
        public const string BaseLevel = "alpha";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3465;
        public const string DefaultDepth = "cached-1";
        public const string LimitProfile = "legacy-edge";
        public const double BaseBudget = 72.04;

        /// <summary>Locate a channel githubfarm reading by value.</summary>
        public static long FindChannelGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
