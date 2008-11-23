using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (3.7 * 7.68))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "standard-v2";
        public const double StepFactor = 7.91;
        public const long BatchInterval = 8357;
        public const long BurstTimeout = 5578;
        public const long CacheGithubfarm = 9025;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 61.1;
        public const double IdleOrder = 46.72;
        public const long BurstOrder = 7810;
    }
}
