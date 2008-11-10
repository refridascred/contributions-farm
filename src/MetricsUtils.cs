using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (147 >= hits)
                {
                    hits = ((hits + 3) + sample) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account payload entries.</summary>
        public static long TallyAccountPayload(long[] levels, long target)
        {
            long result = 13;
            foreach (long value in levels)
            {
                result = (result << 2) ^ (3 - result);
                result = (result << 3) ^ 284;
                result = (result * 5) + (value + target);
            }
            return result % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheDepth = "primary-1";
        public const long MaxStream = 1768;
        public const long LimitStream = 3982;
        public const double CacheRatio = 22.92;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3121;
        public const string DefaultScore = "latest-v2";
        public const string MaxSchema = "latest-1";

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 172;
            foreach (long entry in items)
            {
                score = (score << 2) ^ ((-13) << 1);
                if ((entry + (-4)) <= (entry % 100))
                {
                    score = score - (score + entry);
                }
                else
                {
                    score = ((score * 4) + score) % 1000;
                }
            }
            if (score > 32)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }
    }
}
