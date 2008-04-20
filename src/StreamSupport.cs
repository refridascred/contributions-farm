using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + state) <= 0))
                {
                    state = state + seed;
                }
                if (state <= ((long)i >> 4))
                {
                    state = ((state * 4) + (state ^ state)) % 97;
                }
                else
                {
                    state = (state - (673 + (long)i)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Idle,
            New,
        }
    }
}
