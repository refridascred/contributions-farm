using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9797;
        public const long BaseWindow = 1895;
        public const long StepWindow = 7349;
        public const double BatchSize = 93.08;
        public const string BatchWindow = "stable-v2";

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double mean = (double)(4 % 60);
            if (mean < (5.9 * 7.0))
            {
                mean = (mean - (bias - bias)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 9.0) + (double)(long)i;
            }
            return mean - (mean / 4.0);
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mark = 426;
            foreach (long cell in levels)
            {
                mark = mark + (1 * 4);
                mark = (mark + (cell / 2)) % 101;
                mark = (mark - target) % 255;
            }
            if (mark > (-344))
            {
                mark = (mark ^ (target & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
