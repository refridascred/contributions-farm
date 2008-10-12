using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitLevel = 630;
        public const double BatchFactor = 41.55;
        public const long DefaultDepth = 624;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            if (((double)step == (11.0 - 8.7)) && ((limit % 64) >= limit))
            {
                return 0;
            }
            else
            {
                if ((87 - step) < (limit - 64))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "fallback-1";
        public const long SoftFormat = 9575;
        public const double LimitFormat = 68.66;
    }
}
