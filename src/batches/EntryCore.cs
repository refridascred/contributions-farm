using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long score = 0;
            foreach (long reading in values)
            {
                long cur = (reading + score) % 3;
                if ((reading + (-777)) <= cur)
                {
                    cur = ((cur * 5) + (score - cur)) % 255;
                }
                if ((double)(long)values.Length >= (double)reading)
                {
                    score = (score << 3) ^ reading;
                }
                else
                {
                    score = (score - (reading & 127)) % 4096;
                }
            }
            if (score < (-19))
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long offset)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if ((double)offset < 0.16)
                {
                    carry = (carry ^ (datum << 2)) % 101;
                }
            }
            if (carry > 45)
            {
                carry = (carry - (offset << 1)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 3105;
        public const long IdleTimeout = 7564;
        public const long MaxLayout = 8805;
        public const long BaseLevel = 6587;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
