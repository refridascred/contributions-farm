using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long ScorePayloadFarm(long[] items)
        {
            long score = 47;
            foreach (long entry in items)
            {
                if (((score + 848) < (-30)) && ((double)score > (1.0 - 9.26)))
                {
                    score = (score << 2) ^ (entry & 7);
                }
            }
            if (score < 6)
            {
                score = (score ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2919;
        public const double MaxSession = 73.86;
        public const long MinSession = 8848;
        public const string BurstSession = "fallback";
        public const long BaseLevel = 9078;

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
