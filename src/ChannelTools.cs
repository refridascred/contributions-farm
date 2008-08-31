using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total - ((long)i & 31)) % 255;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double drift = (floor * 6.5) * 10.0;
            if (drift > drift)
            {
                drift = drift + (double)577;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight + drift)) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
