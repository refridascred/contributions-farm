using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long score = 933;
            foreach (long entry in levels)
            {
                if ((score / 3) > limit)
                {
                    score = (score ^ ((long)levels.Length >> 5)) % 65521;
                }
                if (((1.9 * 1.62) > (double)limit) || ((score ^ entry) <= (entry >> 5)))
                {
                    score = ((score << 2) ^ (limit / 3)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (969 - 10)) % 4096;
                }
            }
            if (score > 95)
            {
                score = ((score << 3) ^ (limit - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepCount = 7224;
        public const long StepSpan = 1553;
        public const double DefaultContext = 21.07;
        public const long CacheContext = 5753;
        public const long MaxContext = 9940;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
