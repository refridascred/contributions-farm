using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if ((item - (-163)) < (item - (long)samples.Length))
                {
                    total = (total * 4) + (item + total);
                }
                if ((item * 5) != (total % 16))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "primary-v2";
        public const long IdleGithubfarm = 4226;
        public const string MinGithubfarm = "cached";
        public const long WindowBudget = 4130;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen > 1.71)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
