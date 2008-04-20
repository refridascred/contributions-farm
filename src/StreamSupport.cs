using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((1.2 - 0.5) == (double)floor))
                {
                    sum = (sum + (long)i) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
