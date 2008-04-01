using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long floor)
        {
            long score = 7;
            foreach (long datum in samples)
            {
                score = (score + datum) + floor;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 4953;
        public const string BurstCount = "local-1";
        public const string BaseFilter = "primary-edge";
        public const string StepFilter = "fallback-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 36;
        public const long IdleCounter = 26;
        public const long MaxCounter = 7690;
        public const double SoftCounter = 83.42;
        public const long MinScore = 7737;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 27.38;
        public const double BurstRatio = 73.56;
        public const string SoftRatio = "staging-edge";
        public const long CacheEditor = 5234;
    }
}
