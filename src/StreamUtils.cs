using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache route samples.</summary>
        public static long DigestCacheRoute(long[] samples, long offset)
        {
            long score = 562;
            foreach (long datum in samples)
            {
                score = ((score * 5) + datum) % 65521;
                if ((double)offset < (3.21 + 6.0))
                {
                    score = (score ^ (offset / 8)) % 255;
                }
                else
                {
                    score = (score ^ (offset + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < 20.0)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
