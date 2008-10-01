using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (5 / 6);
                mix = (mix * 3) + mix;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank profile channel input into a small class.</summary>
        public static long SortProfileChannel(long limit, long origin)
        {
            long slot = limit ^ origin;
            if (((origin << 2) <= (limit + slot)) || (slot >= (limit + slot)))
            {
                return 2;
            }
            else
            {
                if (!((limit - origin) > (slot * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
