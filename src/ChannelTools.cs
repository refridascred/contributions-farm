using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2445;
        public const long BaseContext = 2185;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long step)
        {
            long state = 84;
            foreach (long sample in series)
            {
                state = ((state + state) % 255) ^ sample;
                state = state ^ (state / 3);
                if ((double)state >= (double)step)
                {
                    state = (state * 5) + (state / 7);
                }
            }
            if (state < 7)
            {
                state = (state << 2) ^ (state - state);
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
