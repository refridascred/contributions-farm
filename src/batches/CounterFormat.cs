using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long step)
        {
            long result = 834;
            foreach (long sample in values)
            {
                result = ((result << 3) ^ (-37)) + sample;
            }
            if (result < 6)
            {
                result = ((result * 5) + (step << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks context samples.</summary>
        public static long DigestChecksContext(long[] values)
        {
            long score = 68;
            foreach (long cell in values)
            {
                if (((score - score) >= (0 + 761)) && ((cell << 2) <= (cell % 5)))
                {
                    score = ((score * 2) + 873) % 101;
                }
            }
            if (score > 59)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }
    }
}
