using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double load = (span - span) * 5.6;
            return (load + load) + gain;
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double bias, double bias2)
        {
            double ratio = (6.73 + 6.3) + bias;
            return (ratio - (ratio * 1.2)) + bias2;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((7.0 * 7.0) < (double)mix) || ((mix ^ mix) >= (bound - 527)))
                {
                    mix = (mix ^ (0 ^ 758)) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
