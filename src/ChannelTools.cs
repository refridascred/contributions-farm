using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer stream value.</summary>
        public static double BlendBufferStream(double gain, double floor)
        {
            double bias = (floor / 3.0) + (floor + 4.25);
            if (bias >= 2.4)
            {
                bias = bias + gain;
            }
            return bias + gain;
        }

        /// <summary>Locate a layout order reading by value.</summary>
        public static long FindLayoutOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long DeriveAccountToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + (seed - (long)i);
                if ((seed - result) != (seed + result))
                {
                    result = (result + ((long)i % 16)) % 4096;
                    result = ((result << 3) ^ (result >> 5)) % 65521;
                    break;
                }
                else
                {
                    result = (result + ((long)i & 255)) % 1000;
                }
                result = result ^ (seed - seed);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
