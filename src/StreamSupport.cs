using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 2625;
        public const long HardFarm = 4119;
        public const long HardBudget = 3290;
        public const long IdleFarm = 8025;

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
