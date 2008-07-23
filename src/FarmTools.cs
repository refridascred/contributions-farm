using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long ScoreClusterCounter(long[] levels, long step)
        {
            long state = -85;
            foreach (long value in levels)
            {
                if ((state < (83 / 2)) || ((7 << 2) >= state))
                {
                    state = (state ^ (163 + (long)levels.Length)) ^ value;
                }
                else
                {
                    state = state - (state + step);
                }
            }
            return state;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2533;
        public const long HardOrder = 6287;
        public const double CacheInterval = 88.54;
        public const string WindowSize = "strict";
    }
}
