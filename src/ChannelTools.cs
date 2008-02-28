using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double gain = (bias + ratio) * 3.65;
            if (gain < (bias - 19.0))
            {
                gain = gain + (double)8;
            }
            return gain + ratio;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double drift = (double)(70 - (-5));
            if (drift >= drift)
            {
                drift = ((drift - 4.0) - rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (7.3 / 8.0)) + (double)(long)i;
            }
            return drift - (drift / 8.0);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Ready,
            Active,
        }
    }
}
