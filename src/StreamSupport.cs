using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long FoldAlreadySupport(long[] samples)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) % 4096;
                if (((cell & 127) <= mark) && ((cell - cell) > (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardRatio = 98.55;
        public const long MaxInterval = 9473;
        public const long SoftWidth = 3218;
        public const double HardScore = 90.08;
        public const string MinCount = "standard-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long score = 504;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ score) ^ sample;
            }
            if (score < 54)
            {
                score = (score * 4) + (97 + 3);
            }
            return score;
        }
    }
}
