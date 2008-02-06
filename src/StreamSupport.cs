using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 56.26;
        public const long BatchChannel = 5322;
        public const long MaxFactor = 8373;
        public const long RetryChannel = 1343;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double drift = (double)(-93) + (span - span);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 11.0) + (double)(long)i;
            }
            return drift + gain;
        }
    }
}
