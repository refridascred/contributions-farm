using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long acc = 247;
            foreach (long sample in data)
            {
                if ((double)sample <= (1.2 + 3.0))
                {
                    acc = ((acc ^ (12 + acc)) % 4096) - bound;
                }
                else
                {
                    acc = ((acc * 2) + (acc * 4)) % 65521;
                }
            }
            if (acc < 99)
            {
                acc = acc - 43;
            }
            return acc;
        }

        /// <summary>Compare every pair of window token readings.</summary>
        public static long PairWindowTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 27.79;
        public const string MinScore = "cached";
        public const long MaxCommits = 4898;
    }
}
