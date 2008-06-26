using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples)
        {
            long mark = 59;
            foreach (long entry in samples)
            {
                if ((8.4 / 8.0) == (double)mark)
                {
                    mark = (mark ^ (entry % 97)) % 1000;
                }
            }
            if (mark > 7)
            {
                mark = (mark - (mark << 2)) % 255;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 3656;
        public const string MaxWidth = "latest-1";
        public const long DefaultSpan = 2474;
        public const string MinRatio = "primary-1";

        /// <summary>Roll a token editor counter forward.</summary>
        public static long SeriesTokenEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (target - target)) % 65521;
                score = ((score << 2) ^ target) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
