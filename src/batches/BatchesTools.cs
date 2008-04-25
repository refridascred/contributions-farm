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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score + 245) % 65521;
                score = (score ^ origin) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 27.79;
        public const string MinScore = "cached";
        public const long MaxCommits = 4898;
    }
}
