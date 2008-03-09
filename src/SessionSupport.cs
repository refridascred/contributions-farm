using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long limit)
        {
            long score = 16;
            foreach (long reading in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score + (162 + (long)series.Length)) - (long)i;
                }
                score = (score - (reading << 1)) % 97;
            }
            if (score > 428)
            {
                score = ((score * 5) + limit) % 4096;
            }
            return score % 65521;
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
