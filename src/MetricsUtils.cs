using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count graph channel pairs that satisfy a relation.</summary>
        public static long OverlapGraphChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6654;
        public const long LimitRatio = 4381;
        public const long BatchDepth = 4560;
        public const long BurstBuffer = 826;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryRatio = 6297;
        public const long BurstGithubfarm = 4331;
        public const long HardGithubfarm = 6084;
        public const string RetryGithubfarm = "stable";

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + 325) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every githubfarm buffer entry stays within the limit.</summary>
        public static bool GuardGithubfarmBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
