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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((17 * 2) < (value << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
