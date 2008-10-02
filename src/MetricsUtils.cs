using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                if ((0.2 + 7.0) <= (double)state)
                {
                    state = (((state << 2) ^ 677) % 97) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
