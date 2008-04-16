using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double rate = (double)(640 << 1);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)5) + (double)(long)i) - ratio;
            }
            return rate + (bias + bias);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double floor)
        {
            double bias = floor - floor;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + 5.72) + (double)(long)i) - gain;
            }
            return bias + floor;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
