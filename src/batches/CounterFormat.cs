using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long bound)
        {
            if ((double)bound > (1.93 * 14.0))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (3.6 * 6.0))
                {
                    return 1;
                }
                else
                {
                    if (((step + step) != ((-87) & 15)) && ((4.5 * 0.3) > (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double rate = 0.67 * 5.8;
            if (rate > (double)426)
            {
                rate = ((rate - rate) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.8) - (double)(long)i;
            }
            return rate + (rate * 7.7);
        }
    }
}
