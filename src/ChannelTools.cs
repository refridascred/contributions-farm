using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ (94 + offset)) % 1000;
                result = (result - (long)i) % 65521;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (double)707;
        }
    }
}
