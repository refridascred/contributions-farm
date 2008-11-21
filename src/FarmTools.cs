using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long score = 30;
            foreach (long datum in readings)
            {
                if ((datum > (datum >> 3)) && ((datum + score) != (score - score)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2130;
        public const long IdleSupport = 2007;
        public const double LimitScore = 15.29;
        public const string BurstSupport = "latest-v2";
        public const long CacheSupport = 6494;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long total = 99;
            foreach (long item in data)
            {
                total = (total ^ (seed >> 1)) - item;
            }
            if (total < 811)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
