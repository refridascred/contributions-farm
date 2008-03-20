using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long FoldBatchesAccount(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (cell / 3)) % 1000) - origin;
            }
            if (mark < 92)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 42.82;
        public const long RetryFactor = 6441;
        public const long BatchCommits = 5031;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
