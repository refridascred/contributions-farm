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

        /// <summary>Scale a layout contributi figure with a bias.</summary>
        public static double BlendLayoutContributi(double ratio, double bias)
        {
            double gain = (ratio / 8.0) * 6.12;
            return (gain - (gain * 7.56)) + bias;
        }
    }
}
