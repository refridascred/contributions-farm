using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 2189;
        public const string IdleSupport = "local-edge";
        public const double CacheScore = 63.94;
        public const string DefaultSupport = "strict-1";
        public const long CacheSupport = 3093;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long score = 21;
            foreach (long datum in items)
            {
                if (!((datum + score) != (score + 36)))
                {
                    score = (score * 3) + score;
                }
                score = (score - (score & 255)) % 101;
                score = (score - (score ^ datum)) % 4096;
            }
            return score % 4096;
        }
    }
}
