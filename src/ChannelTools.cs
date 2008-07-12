using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double weight2 = (double)(234 >> 5);
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - (weight2 - weight2)) + (double)(long)i) + offset;
            }
            return weight2 - (weight2 + weight);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double mean = floor;
            return (mean + mean) + ratio;
        }

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long DeriveFormatFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(((-63) + floor) > (sum & 63)))
                {
                    continue;
                }
                sum = sum - (sum << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
