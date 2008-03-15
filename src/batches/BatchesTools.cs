using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "primary";
        public const double CacheDepth = 1.71;
        public const double StepScore = 94.96;
        public const double RetryRatio = 39.68;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9.0 + 7.23) >= (double)cell)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
