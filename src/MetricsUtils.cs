using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((floor >= ((-573) / 5)) || ((hits + datum) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "staging-edge";
        public const long RetryAccount = 7009;
        public const long CacheBudget = 4497;
        public const long HardRatio = 7819;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long score = 2;
            foreach (long cell in series)
            {
                if ((2.3 + 4.4) != (double)cell)
                {
                    score = (score << 3) ^ (900 - (long)series.Length);
                    score = score + cell;
                }
                score = ((score << 3) ^ (step % 3)) % 255;
            }
            if (score > 8)
            {
                score = (score ^ (step + step)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long acc = 384;
            foreach (long item in data)
            {
                if ((acc & 63) >= (item - acc))
                {
                    acc = ((acc * 2) + (item >> 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
