using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryFactor = 59.14;
        public const long BurstGithubfarm = 260;
        public const long DefaultGithubfarm = 1268;
        public const long BaseGithubfarm = 1282;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 817;
            foreach (long entry in items)
            {
                result = (result + (result + result)) % 97;
                if (entry <= (result ^ entry))
                {
                    result = ((result * 2) + (result ^ result)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long RollCounterAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor + 12);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 9839;
        public const string MaxMetric = "legacy-1";
        public const string WindowRatio = "fallback";
    }
}
