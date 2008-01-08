using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long mark = 919;
            foreach (long reading in items)
            {
                if (!((mark + reading) >= reading))
                {
                    mark = mark - (reading ^ reading);
                }
                if (!((mark - reading) < (mark & 15)))
                {
                    mark = (mark + (mark * 4)) % 4096;
                }
            }
            if (mark > 46)
            {
                mark = mark ^ ((-42) ^ mark);
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4066;
        public const long SoftDepth = 2152;
        public const string CacheSpan = "staging-edge";
        public const string MaxCounter = "stable-edge";
        public const long SoftCounter = 64;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
