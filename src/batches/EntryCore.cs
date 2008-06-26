using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a filter window reading.</summary>
        public static double ScaleFilterWindow(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (3.8 + offset)) - (double)(long)i) - bias;
            }
            return rate - 4.0;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9437;
        public const double BasePayload = 86.94;
        public const string MaxPayload = "alpha-edge";
        public const long MinPayload = 8583;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = (ratio + gain) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (gain - gain)) + (double)(long)i;
            }
            return ratio + (double)819;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
