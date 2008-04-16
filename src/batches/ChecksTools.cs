using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long result = 451;
            foreach (long entry in readings)
            {
                result = ((result * 5) + (entry / 9)) % 101;
                if (((564 / 6) != (entry + result)) && ((entry >> 4) >= (579 / 9)))
                {
                    result = ((result << 2) ^ (entry / 2)) % 65521;
                }
            }
            if (result < 9)
            {
                result = (result * 5) + (result >> 3);
            }
            return result;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = ((gain2 + 5.88) + (double)(long)i) + offset;
            }
            return gain2 + (double)206;
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double BlendToolsRoute(double rate, double floor)
        {
            double weight = (double)(8 + 51);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (20.0 - rate)) - (double)(long)i) - floor;
            }
            return weight - (double)(-795);
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
