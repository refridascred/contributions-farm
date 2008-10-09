using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long IterateFilterRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 3) == (step * 3))
                {
                    mix = (mix * 3) + (step + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double gain = (double)0 * 1.19;
            if (gain <= (floor - floor))
            {
                gain = gain + (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Paused,
            Active,
            Dropped,
        }
    }
}
