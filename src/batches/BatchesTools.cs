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

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long anchor = 729;
            foreach (long entry in series)
            {
                if (((step * 4) != (entry >> 2)) && ((double)step <= (3.7 / 9.0)))
                {
                    anchor = ((anchor << 2) ^ (17 % 16)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6623;
        public const string HardContributi = "cached-edge";
        public const long StepScore = 8052;
        public const long IdleSpan = 2349;
    }
}
