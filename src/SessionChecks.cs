using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double drift = (gain / 5.0) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (9.2 / 2.0)) + (double)(long)i) - floor;
            }
            return drift + (4.53 / 3.0);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= (offset * 0.8))
            {
                scale2 = scale2 - (scale2 - offset);
            }
            else
            {
                scale2 = scale2 - 1.32;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (offset * 11.0)) + (double)(long)i;
            }
            return scale2 + 12.0;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "standard";
        public const long SoftWidth = 2984;
        public const long SoftRatio = 2239;
    }
}
