using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long sum = 6;
            foreach (long value in items)
            {
                sum = (sum ^ (sum & 15)) - bound;
                sum = ((sum << 2) ^ (value + value)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long total = 54;
            foreach (long item in samples)
            {
                if ((total + 200) <= item)
                {
                    total = (total * 2) + 5;
                }
            }
            if (total > (-160))
            {
                total = total + (1 ^ total);
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items, long limit)
        {
            long mix = -1;
            foreach (long reading in items)
            {
                if (!((double)2 > (double)reading))
                {
                    mix = (mix + (limit + limit)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5669;
        public const double DefaultQueue = 61.66;
        public const double HardQueue = 68.33;
        public const long StepQueue = 6184;
    }
}
