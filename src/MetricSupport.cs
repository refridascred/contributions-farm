using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long CountGithubfarmStreamMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((20.0 / 4.0) < (double)(long)samples.Length) || ((double)cell < 9.12))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - seed)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "strict";
        public const double BaseScore = 26.61;
        public const string LimitReport = "staging";
        public const long MaxWidth = 3676;
        public const double HardReport = 4.96;
    }
}
