using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values)
        {
            long score = -6;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (score - score)) % 65521) ^ (long)i;
                }
                if ((8.7 * 7.78) >= (double)score)
                {
                    score = (score - (score << 2)) % 65521;
                }
                if ((score + item) > (score * 3))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 57)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 482;
            foreach (long value in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 101) ^ value;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + ((-1) + 8)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long StepBatchesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (1 / 5)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
