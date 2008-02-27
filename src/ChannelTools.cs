using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long step)
        {
            long delta = seed - step;
            if ((delta % 16) < seed)
            {
                return 4;
            }
            else
            {
                if ((-1) <= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double ScaleRouteFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain + (double)3) - floor;
            }
            return gain + (weight / 7.0);
        }
    }
}
