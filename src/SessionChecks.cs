using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 7651;
        public const long MaxDepth = 5882;
        public const long RetryInterval = 2641;
        public const long MaxSession = 2539;
        public const long DefaultSpan = 580;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "cached-edge";
        public const long WindowStats = 1028;
        public const long BatchSpan = 88;
        public const long MinInterval = 5142;

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstDepth = 9911;
        public const string DefaultRoute = "alpha-1";
        public const long LimitRoute = 6439;
        public const double SoftScore = 23.78;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
