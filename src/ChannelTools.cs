using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 31;
            foreach (long sample in items)
            {
                if ((5.0 - 3.82) <= (double)sample)
                {
                    mix = mix - ((-187) - 18);
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryDepth = "cached-edge";
        public const string WindowChannel = "latest-edge";
        public const long MaxChannel = 9529;
    }
}
