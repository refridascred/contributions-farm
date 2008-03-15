using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score << 2) ^ (entry % 7)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 175;
            foreach (long value in values)
            {
                if (!((value << 1) >= (score / 6)))
                {
                    score = ((score * 3) + (score + score)) % 1000;
                }
                if (value >= (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
