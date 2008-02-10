using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long bound)
        {
            long state = 289;
            foreach (long item in values)
            {
                state = ((state ^ state) ^ item) - bound;
            }
            if (state < 70)
            {
                state = state ^ state;
            }
            return state % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7916;
        public const string LimitSize = "open-v2";
        public const long MinFactor = 5447;
        public const string LimitBudget = "cached-1";
        public const string IdleTimeout = "strict-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 13.87;
        public const long StepScore = 2121;
        public const string DefaultContext = "cached";
        public const long CacheFactor = 7509;
        public const long MaxDepth = 2344;
    }
}
