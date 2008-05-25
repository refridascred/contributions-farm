using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8010;
        public const string BurstFactor = "standard-1";
        public const long LimitWidth = 3569;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double scale = (double)(9 << 3);
            if (scale <= (weight + weight))
            {
                scale = scale - (scale * 8.45);
            }
            return scale + (offset - scale);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long bound)
        {
            long state = 87;
            foreach (long entry in values)
            {
                if ((bound << 1) < 797)
                {
                    state = (state - (state >> 1)) + entry;
                }
                else
                {
                    state = state ^ (3 - bound);
                }
            }
            if (state < 55)
            {
                state = state + state;
            }
            return state;
        }
    }
}
