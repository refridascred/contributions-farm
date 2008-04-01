using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double weight, double bias)
        {
            double mean = 3.61 - (weight + bias);
            if (mean <= weight)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (bias * 6.5);
            }
            return mean - (bias / 4.0);
        }

        /// <summary>Blend two channel order measurements.</summary>
        public static double BlendChannelOrder(double ratio, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = load + span;
            }
            else
            {
                load = load + (double)433;
            }
            return load + ratio;
        }
    }
}
