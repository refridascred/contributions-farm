using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a farm profile reading.</summary>
        public static double ProjectFarmProfile(double gain, double offset)
        {
            double scale = (double)(350 * 3);
            return (scale + gain) + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 96.82;
        public const long HardFormat = 8432;
        public const string SoftRatio = "local";
    }
}
