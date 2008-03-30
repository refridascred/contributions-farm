using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (score > (score << 3))
                {
                    score = ((score - (score >> 2)) % 1000) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 3) ^ (target / 5)) % 4096) - (long)i2;
                }
                if (!((anchor % 10) != ((long)i << 2)))
                {
                    anchor = anchor - (anchor / 8);
                }
                else
                {
                    anchor = ((anchor * 3) + target) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
