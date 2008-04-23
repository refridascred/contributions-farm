using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleCount = 84.33;
        public const long RetryFactor = 1940;
        public const double SoftGithubfarm = 62.73;
        public const string StepSize = "local-1";
        public const long BurstFactor = 4744;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (bound + bound)) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a graph format reading by value.</summary>
        public static long LookupGraphFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
