using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long acc = 571;
            foreach (long value in levels)
            {
                acc = (acc * 2) + (acc + value);
                if ((acc + value) == (3 - acc))
                {
                    acc = acc - (acc / 9);
                }
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long origin)
        {
            long acc = 242;
            foreach (long cell in series)
            {
                acc = acc - (origin << 2);
                if (((7 + 3) <= cell) || ((origin % 12) != (acc + (-1))))
                {
                    acc = acc - (cell + cell);
                }
                else
                {
                    acc = ((acc * 3) + (acc + cell)) % 101;
                    acc = (acc << 2) ^ 1;
                }
                if (!((7 + origin) <= (acc - cell)))
                {
                    acc = (acc - (origin ^ 723)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + 1) % 255;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
