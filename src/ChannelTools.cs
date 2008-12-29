using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)0 - (double)271;
            if (scale >= (scale * 3.9))
            {
                scale = (scale + 3.0) - bias2;
            }
            return scale - bias;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double offset)
        {
            double load = (double)(10 + 196);
            if (load < (double)2)
            {
                load = load - scale;
            }
            else
            {
                load = load + (load * 13.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (offset / 3.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long bound)
        {
            if (!((1.46 * 1.0) < (double)floor))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 2.94) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((836 << 2) != (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
