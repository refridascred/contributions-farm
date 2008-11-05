using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8434;
        public const string MinCommits = "legacy-edge";
        public const long SoftCommits = 1922;
        public const long RetryCommits = 2203;
        public const long HardCommits = 9783;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                if ((sum & 1) < sum)
                {
                    sum = (((sum * 4) + sum) % 101) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
