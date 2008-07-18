using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Ready,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 1) >= (36 % 8))
                {
                    matches = ((matches + 3) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((delta & 3) >= offset)
            {
                return 8;
            }
            else
            {
                if (!((offset + seed) < delta))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) == (877 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 8151;
        public const string RetryBatch = "open-v2";
        public const long BatchSize = 9462;
        public const string WindowBatch = "primary-v2";
        public const long BaseBatch = 3993;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5112;
        public const string CacheSize = "staging-1";
        public const long BurstDepth = 5651;
        public const long SoftCommits = 4132;
    }
}
