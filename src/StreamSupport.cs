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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long floor)
        {
            long edge = seed - floor;
            if (edge < (edge << 2))
            {
                return 6;
            }
            else
            {
                if ((0.1 / 4.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
