using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 166;
        public const long SoftContributi = 4091;
        public const double BatchContributi = 22.7;

        /// <summary>Blend two session channel measurements.</summary>
        public static double ProjectSessionChannel(double scale, double offset)
        {
            double mean = (offset * 0.9) - (scale * 7.3);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
