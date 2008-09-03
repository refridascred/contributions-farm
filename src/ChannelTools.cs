using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two channel session measurements.</summary>
        public static double AdjustChannelSession(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)41) - (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftFactor = 3149;
        public const long DefaultSize = 1831;
        public const long DefaultMetrics = 8816;
        public const long BaseDepth = 7195;
        public const string MaxFactor = "stable-1";
    }
}
