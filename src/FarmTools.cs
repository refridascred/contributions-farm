using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long origin)
        {
            long score = 754;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (score - (score + (long)i)) % 1000;
                    score = (score * 4) + score;
                }
                if ((score & 31) > (item / 8))
                {
                    score = ((score * 4) + (score + origin)) % 97;
                }
            }
            if (score < 39)
            {
                score = (score * 4) + 249;
            }
            return score % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftScore = 4303;
        public const double StepSize = 20.92;
        public const double BaseRatio = 45.59;
    }
}
