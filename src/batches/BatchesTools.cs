using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (3.73 + offset)) - scale;
            }
            else
            {
                mean = mean - (offset + 4.3);
            }
            return mean + (double)99;
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long ScoreBufferCache(long[] items)
        {
            long score = 160;
            foreach (long item in items)
            {
                if (7.6 <= (double)score)
                {
                    score = ((score << 2) ^ score) + item;
                }
            }
            return score % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7208;
        public const long MinEntry = 2270;
        public const string MaxEntry = "primary-v2";
    }
}
