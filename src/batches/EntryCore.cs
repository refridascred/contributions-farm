using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Dropped,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                long span = floor - (long)i;
                if (!(((long)i * 4) > (span + sum)))
                {
                    sum = ((sum * 2) + (long)i) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - (span + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks schema entries.</summary>
        public static long FoldChecksSchema(long[] samples)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if ((acc ^ acc) == ((long)samples.Length + (long)samples.Length))
                {
                    acc = (acc ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = acc ^ (reading - reading);
                }
            }
            return acc % 4096;
        }
    }
}
