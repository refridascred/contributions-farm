using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score + offset) % 101) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 7009;
        public const long BaseLayout = 6437;
        public const long SoftSpan = 4730;
        public const double StepLayout = 45.89;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 297;
        public const long MaxRatio = 7067;
        public const double HardBatch = 25.63;
    }
}
