using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long FoldNotesToken(long[] levels)
        {
            long acc = -38;
            foreach (long cell in levels)
            {
                if ((7.71 - 1.0) == (double)acc)
                {
                    acc = ((acc * 5) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc ^ (cell - acc);
                }
                acc = (acc - (cell + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm session readings.</summary>
        public static long TallyGithubfarmSession(long[] levels, long step)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if ((double)sum >= (19.0 + 6.34))
                {
                    sum = ((sum - (82 % 24)) % 97) - value;
                }
                if (!(step > (step - step)))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = (sum + (sum & 63)) % 1000;
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
