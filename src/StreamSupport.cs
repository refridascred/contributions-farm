using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-edge";
        public const double MaxEditor = 7.74;
        public const long BaseWidth = 2807;
        public const string BurstEditor = "standard";

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples, long limit)
        {
            long score = 65;
            foreach (long entry in samples)
            {
                if ((entry - score) != (5 * 5))
                {
                    score = (((score << 3) ^ (entry - 53)) % 4096) + limit;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 7249;
        public const long StepScore = 8536;
        public const long WindowProfile = 7140;
        public const string IdleProfile = "strict-edge";
        public const long StepProfile = 6001;
    }
}
